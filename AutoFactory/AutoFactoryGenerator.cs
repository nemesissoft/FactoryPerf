using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using AutoFactory.Utils;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;


#nullable enable

namespace AutoFactory
{
    [Generator]
    public class AutoFactoryGenerator : ISourceGenerator
    {
        internal const string AUTO_ATTRIBUTE_NAME = @"AutoFactoryAttribute";
        private const string AUTO_ATTRIBUTE_SOURCE = @"using System;
namespace Auto
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
    sealed class " + AUTO_ATTRIBUTE_NAME + @" : Attribute
    {
        public Type ServiceType { get; }

        public " + AUTO_ATTRIBUTE_NAME + @"(Type serviceType) => ServiceType = serviceType;
    }
}
";

        private const string ADDITIONAL_ATTRIBUTES = @"
using System;
using System.Diagnostics;

namespace Auto
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = true)]
    sealed class ImplementationNameAttribute : Attribute
    {
        public string RegisterAs { get; }

        public ImplementationNameAttribute(string registerAs) => RegisterAs = registerAs;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
    sealed class AlternativeRegistrationAttribute : Attribute
    {
        public AlternativeRegistrations RegisterBy { get; }

        public AlternativeRegistrationAttribute(AlternativeRegistrations registerBy) => RegisterBy = registerBy;
    }

    [Flags]
    public enum AlternativeRegistrations : byte
    {
        [Obsolete(""Used only as default value"", true)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        None = 0, 
        TypeName = 1, 
        FullTypeName = 2,
        AssemblyQualifiedName = 4,
    }
}
";

        public void Initialize(GeneratorInitializationContext context) => context.RegisterForSyntaxNotifications(() => new AutoFactorySyntaxReceiver());

        public void Execute(GeneratorExecutionContext context)
        {
            //Debugger.Launch();
            //context.CheckDebugger(nameof(AutoFactoryGenerator));

            context.AddSource(AUTO_ATTRIBUTE_NAME, SourceText.From(AUTO_ATTRIBUTE_SOURCE, Encoding.UTF8));
            //context.AddSource("ADDITIONAL_ATTRIBUTES", SourceText.From(ADDITIONAL_ATTRIBUTES, Encoding.UTF8));

            if (context.SyntaxReceiver is not AutoFactorySyntaxReceiver receiver || context.Compilation is not CSharpCompilation cSharpCompilation) return;

            var options = cSharpCompilation.SyntaxTrees[0].Options as CSharpParseOptions;
            var compilation = context.Compilation.AddSyntaxTrees(
                CSharpSyntaxTree.ParseText(SourceText.From(AUTO_ATTRIBUTE_SOURCE, Encoding.UTF8), options)
                /*,
                CSharpSyntaxTree.ParseText(SourceText.From(ADDITIONAL_ATTRIBUTES, Encoding.UTF8), options)*/
            );

            var autoAttributeSymbol = compilation.GetTypeByMetadataName($"Auto.{AUTO_ATTRIBUTE_NAME}");
            if (autoAttributeSymbol is null)
            {
                //TODO ReportDiagnostics(context, NoAutoAttributeRule, null);
                return;
            }

            /*var implementationNameAttributeSymbol = compilation.GetTypeByMetadataName("Auto.ImplementationNameAttribute");
            if (implementationNameAttributeSymbol is null)
            {
                //TODO ReportDiagnostics
                return;
            }

            var alternativeRegistrationAttributeSymbol = compilation.GetTypeByMetadataName("Auto.AlternativeRegistrationAttribute");
            if (alternativeRegistrationAttributeSymbol is null)
            {
                //TODO ReportDiagnostics
                return;
            }*/

            foreach (var type in receiver.CandidateTypes)
            {
                var model = compilation.GetSemanticModel(type.SyntaxTree);

                if (!ShouldProcessType(type, autoAttributeSymbol, out INamedTypeSymbol serviceTypeSymbol)) continue;
                /*{
                    if (!typeSymbol.ContainingSymbol.Equals(typeSymbol.ContainingNamespace, SymbolEqualityComparer.Default))
                    {
                        ReportDiagnostics(context, NamespaceAndTypeNamesEqualRule, typeSymbol);
                        continue;
                    }

                    var namespaces = new HashSet<string> { "System", "Nemesis.TextParsers.Parsers", "Nemesis.TextParsers.Utils", "Nemesis.TextParsers" };
                    if (type.SyntaxTree.GetRoot() is CompilationUnitSyntax compilationUnit)
                    {
                        var sourceNamespacesWithoutUsing = compilationUnit.Usings.Select(u => u
                                .WithUsingKeyword(SyntaxFactory.MissingToken(SyntaxKind.UsingKeyword))
                                .WithSemicolonToken(SyntaxFactory.MissingToken(SyntaxKind.SemicolonToken))
                                .ToString())
                            .ToList();

                        foreach (var ns in sourceNamespacesWithoutUsing)
                            namespaces.Add(ns);
                    }

                    if (TryGetMembers(typeSymbol, context, namespaces, out var members) && members != null)
                    {
                        var settings = GeneratedDeconstructableSettings.FromDeconstructableSettingsAttribute(deconstructableSettingsAttributeData);

                        string typeModifiers = GetTypeModifiers(type);

                        string classSource = RenderRecord(typeSymbol, typeModifiers, members, settings, namespaces);
                        context.AddSource($"{typeSymbol.Name}_AutoDeconstructable.cs", SourceText.From(classSource, Encoding.UTF8));
                    }
                }*/
            }
        }

        private bool ShouldProcessType(TypeDeclarationSyntax type, INamedTypeSymbol autoAttributeSymbol, out INamedTypeSymbol namedTypeSymbol)
        {
            namedTypeSymbol = null;
            return false;
        }

        static AttributeData? GetAttribute(ISymbol typeSymbol, ISymbol attributeSymbol) =>
            typeSymbol.GetAttributes().FirstOrDefault(ad =>
                ad?.AttributeClass is { } @class && @class.Equals(attributeSymbol, SymbolEqualityComparer.Default));

        class AutoFactorySyntaxReceiver : ISyntaxReceiver
        {
            public List<TypeDeclarationSyntax> CandidateTypes { get; } = new();

            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                if (syntaxNode is TypeDeclarationSyntax tds && tds.AttributeLists.Count > 0)
                    CandidateTypes.Add(tds);
            }
        }
    }
}
