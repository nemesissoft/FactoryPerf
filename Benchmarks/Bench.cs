using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

using Example;

namespace FactoryPerf
{
    /*12 items:
|              Method |        Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |------------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|              Simple | 12,018.2 ns | 132.32 ns | 123.77 ns |  1.00 | 0.3815 |     - |     - |   2.34 KB |
|           Generated |    872.4 ns |   7.37 ns |   6.89 ns |  0.07 | 0.3824 |     - |     - |   2.34 KB |
| GeneratedDictionary |  1,538.1 ns |   7.34 ns |   6.87 ns |  0.13 | 0.3815 |     - |     - |   2.34 KB |

    400 items:
|                   Method |      Mean |     Error |    StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated | Timer/Op | BranchInstructions/Op | BranchMispredictions/Op |
|------------------------- |----------:|----------:|----------:|------:|-------:|-------:|------:|----------:|---------:|----------------------:|------------------------:|
|                   Simple | 59.076 us | 0.2595 us | 0.2301 us |  1.00 | 1.5259 | 0.0610 |     - |   9.69 KB |       67 |                48,638 |                     353 |
|                Generated |  8.271 us | 0.0381 us | 0.0338 us |  0.14 | 1.5335 |      - |     - |    9.4 KB |        9 |                 5,192 |                      97 |
| CaseInsensitiveGenerated | 10.434 us | 0.0723 us | 0.0641 us |  0.18 | 1.5259 |      - |     - |    9.4 KB |       12 |                 7,604 |                     157 |
|      GeneratedDictionary | 14.137 us | 0.1305 us | 0.1221 us |  0.24 | 1.5259 |      - |     - |    9.4 KB |       13 |                 7,702 |                     162 |
     */

    [MemoryDiagnoser]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [HardwareCounters(HardwareCounter.BranchMispredictions, HardwareCounter.BranchInstructions, HardwareCounter.Timer)]
    public class Bench
    {
        private static readonly string[] _classNames = new[]
        {
            "A001", "A002", "A003", "A004", "A005", "A006", "A007", "A008", "A009", "A010", "A011", "A012", "A013",
            "A014", "A015", "A016", "A017", "A018", "A019", "A020", "A021", "A022", "A023", "A024", "A025", "A026",
            "A027", "A028", "A029", "A030", "A031", "A032", "A033", "A034", "A035", "A036", "A037", "A038", "A039",
            "A040", "A041", "A042", "A043", "A044", "A045", "A046", "A047", "A048", "A049", "A050", "A051", "A052",
            "A053", "A054", "A055", "A056", "A057", "A058", "A059", "A060", "A061", "A062", "A063", "A064", "A065",
            "A066", "A067", "A068", "A069", "A070", "A071", "A072", "A073", "A074", "A075", "A076", "A077", "A078",
            "A079", "A080", "A081", "A082", "A083", "A084", "A085", "A086", "A087", "A088", "A089", "A090", "A091",
            "A092", "A093", "A094", "A095", "A096", "A097", "A098", "A099", "A100", "A101", "A102", "A103", "A104",
            "A105", "A106", "A107", "A108", "A109", "A110", "A111", "A112", "A113", "A114", "A115", "A116", "A117",
            "A118", "A119", "A120", "A121", "A122", "A123", "A124", "A125", "A126", "A127", "A128", "A129", "A130",
            "A131", "A132", "A133", "A134", "A135", "A136", "A137", "A138", "A139", "A140", "A141", "A142", "A143",
            "A144", "A145", "A146", "A147", "A148", "A149", "A150", "A151", "A152", "A153", "A154", "A155", "A156",
            "A157", "A158", "A159", "A160", "A161", "A162", "A163", "A164", "A165", "A166", "A167", "A168", "A169",
            "A170", "A171", "A172", "A173", "A174", "A175", "A176", "A177", "A178", "A179", "A180", "A181", "A182",
            "A183", "A184", "A185", "A186", "A187", "A188", "A189", "A190", "A191", "A192", "A193", "A194", "A195",
            "A196", "A197", "A198", "A199", "A200", "A201", "A202", "A203", "A204", "A205", "A206", "A207", "A208",
            "A209", "A210", "A211", "A212", "A213", "A214", "A215", "A216", "A217", "A218", "A219", "A220", "A221",
            "A222", "A223", "A224", "A225", "A226", "A227", "A228", "A229", "A230", "A231", "A232", "A233", "A234",
            "A235", "A236", "A237", "A238", "A239", "A240", "A241", "A242", "A243", "A244", "A245", "A246", "A247",
            "A248", "A249", "A250", "A251", "A252", "A253", "A254", "A255", "A256", "A257", "A258", "A259", "A260",
            "A261", "A262", "A263", "A264", "A265", "A266", "A267", "A268", "A269", "A270", "A271", "A272", "A273",
            "A274", "A275", "A276", "A277", "A278", "A279", "A280", "A281", "A282", "A283", "A284", "A285", "A286",
            "A287", "A288", "A289", "A290", "A291", "A292", "A293", "A294", "A295", "A296", "A297", "A298", "A299",
            "A300", "A301", "A302", "A303", "A304", "A305", "A306", "A307", "A308", "A309", "A310", "A311", "A312",
            "A313", "A314", "A315", "A316", "A317", "A318", "A319", "A320", "A321", "A322", "A323", "A324", "A325",
            "A326", "A327", "A328", "A329", "A330", "A331", "A332", "A333", "A334", "A335", "A336", "A337", "A338",
            "A339", "A340", "A341", "A342", "A343", "A344", "A345", "A346", "A347", "A348", "A349", "A350", "A351",
            "A352", "A353", "A354", "A355", "A356", "A357", "A358", "A359", "A360", "A361", "A362", "A363", "A364",
            "A365", "A366", "A367", "A368", "A369", "A370", "A371", "A372", "A373", "A374", "A375", "A376", "A377",
            "A378", "A379", "A380", "A381", "A382", "A383", "A384", "A385", "A386", "A387", "A388", "A389", "A390",
            "A391", "A392", "A393", "A394", "A395", "A396", "A397", "A398", "A399", "A400"
        };
        private static readonly SimpleFactory _simpleFactory = SimpleFactory.GetDefault();
        [Benchmark(Baseline = true)]
        public int Simple()
        {
            object o = new A001();
            for (int i = 0; i < _classNames.Length; i++)
                o = _simpleFactory.Create(_classNames[i]);

            return o.GetHashCode();
        }



        private static readonly ManualGeneratedFactory ManualGeneratedFactory = new();
        [Benchmark]
        public int Generated()
        {
            object o = new A001();
            for (int i = 0; i < _classNames.Length; i++)
                o = ManualGeneratedFactory.Create(_classNames[i]);

            return o.GetHashCode();
        }

        private static readonly ManualCaseInsensitiveGeneratedFactory ManualCaseInsensitiveGeneratedFactory = new();
        [Benchmark]
        public int CaseInsensitiveGenerated()
        {
            object o = new A001();
            for (int i = 0; i < _classNames.Length; i++)
                o = ManualCaseInsensitiveGeneratedFactory.Create(_classNames[i]);

            return o.GetHashCode();
        }


        private static readonly ManualGeneratedDictionaryFactory ManualGeneratedDictionaryFactory = ManualGeneratedDictionaryFactory.GetDefault();
        [Benchmark]
        public int GeneratedDictionary()
        {
            object o = new A001();
            for (int i = 0; i < _classNames.Length; i++)
                o = ManualGeneratedDictionaryFactory.Create(_classNames[i]);

            return o.GetHashCode();
        }       
    }
}
