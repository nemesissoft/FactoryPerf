﻿namespace FactoryPerf
{
    /*string.Join(Environment.NewLine,
                Enumerable.Range(1, 100).Select(i=>i.ToString("000")).Select(s=>$"public class A{s} : IComponent {{ }}")
                    )*/
    public interface IComponent
    {
    }

    public class A001 : IComponent { }
    public class A002 : IComponent { }
    public class A003 : IComponent { }
    public class A004 : IComponent { }
    public class A005 : IComponent { }
    public class A006 : IComponent { }
    public class A007 : IComponent { }
    public class A008 : IComponent { }
    public class A009 : IComponent { }
    public class A010 : IComponent { }
    public class A011 : IComponent { }
    public class A012 : IComponent { }
    public class A013 : IComponent { }
    public class A014 : IComponent { }
    public class A015 : IComponent { }
    public class A016 : IComponent { }
    public class A017 : IComponent { }
    public class A018 : IComponent { }
    public class A019 : IComponent { }
    public class A020 : IComponent { }
    public class A021 : IComponent { }
    public class A022 : IComponent { }
    public class A023 : IComponent { }
    public class A024 : IComponent { }
    public class A025 : IComponent { }
    public class A026 : IComponent { }
    public class A027 : IComponent { }
    public class A028 : IComponent { }
    public class A029 : IComponent { }
    public class A030 : IComponent { }
    public class A031 : IComponent { }
    public class A032 : IComponent { }
    public class A033 : IComponent { }
    public class A034 : IComponent { }
    public class A035 : IComponent { }
    public class A036 : IComponent { }
    public class A037 : IComponent { }
    public class A038 : IComponent { }
    public class A039 : IComponent { }
    public class A040 : IComponent { }
    public class A041 : IComponent { }
    public class A042 : IComponent { }
    public class A043 : IComponent { }
    public class A044 : IComponent { }
    public class A045 : IComponent { }
    public class A046 : IComponent { }
    public class A047 : IComponent { }
    public class A048 : IComponent { }
    public class A049 : IComponent { }
    public class A050 : IComponent { }
    public class A051 : IComponent { }
    public class A052 : IComponent { }
    public class A053 : IComponent { }
    public class A054 : IComponent { }
    public class A055 : IComponent { }
    public class A056 : IComponent { }
    public class A057 : IComponent { }
    public class A058 : IComponent { }
    public class A059 : IComponent { }
    public class A060 : IComponent { }
    public class A061 : IComponent { }
    public class A062 : IComponent { }
    public class A063 : IComponent { }
    public class A064 : IComponent { }
    public class A065 : IComponent { }
    public class A066 : IComponent { }
    public class A067 : IComponent { }
    public class A068 : IComponent { }
    public class A069 : IComponent { }
    public class A070 : IComponent { }
    public class A071 : IComponent { }
    public class A072 : IComponent { }
    public class A073 : IComponent { }
    public class A074 : IComponent { }
    public class A075 : IComponent { }
    public class A076 : IComponent { }
    public class A077 : IComponent { }
    public class A078 : IComponent { }
    public class A079 : IComponent { }
    public class A080 : IComponent { }
    public class A081 : IComponent { }
    public class A082 : IComponent { }
    public class A083 : IComponent { }
    public class A084 : IComponent { }
    public class A085 : IComponent { }
    public class A086 : IComponent { }
    public class A087 : IComponent { }
    public class A088 : IComponent { }
    public class A089 : IComponent { }
    public class A090 : IComponent { }
    public class A091 : IComponent { }
    public class A092 : IComponent { }
    public class A093 : IComponent { }
    public class A094 : IComponent { }
    public class A095 : IComponent { }
    public class A096 : IComponent { }
    public class A097 : IComponent { }
    public class A098 : IComponent { }
    public class A099 : IComponent { }
    public class A100 : IComponent { }
    public class A101 : IComponent { }
    public class A102 : IComponent { }
    public class A103 : IComponent { }
    public class A104 : IComponent { }
    public class A105 : IComponent { }
    public class A106 : IComponent { }
    public class A107 : IComponent { }
    public class A108 : IComponent { }
    public class A109 : IComponent { }
    public class A110 : IComponent { }
    public class A111 : IComponent { }
    public class A112 : IComponent { }
    public class A113 : IComponent { }
    public class A114 : IComponent { }
    public class A115 : IComponent { }
    public class A116 : IComponent { }
    public class A117 : IComponent { }
    public class A118 : IComponent { }
    public class A119 : IComponent { }
    public class A120 : IComponent { }
    public class A121 : IComponent { }
    public class A122 : IComponent { }
    public class A123 : IComponent { }
    public class A124 : IComponent { }
    public class A125 : IComponent { }
    public class A126 : IComponent { }
    public class A127 : IComponent { }
    public class A128 : IComponent { }
    public class A129 : IComponent { }
    public class A130 : IComponent { }
    public class A131 : IComponent { }
    public class A132 : IComponent { }
    public class A133 : IComponent { }
    public class A134 : IComponent { }
    public class A135 : IComponent { }
    public class A136 : IComponent { }
    public class A137 : IComponent { }
    public class A138 : IComponent { }
    public class A139 : IComponent { }
    public class A140 : IComponent { }
    public class A141 : IComponent { }
    public class A142 : IComponent { }
    public class A143 : IComponent { }
    public class A144 : IComponent { }
    public class A145 : IComponent { }
    public class A146 : IComponent { }
    public class A147 : IComponent { }
    public class A148 : IComponent { }
    public class A149 : IComponent { }
    public class A150 : IComponent { }
    public class A151 : IComponent { }
    public class A152 : IComponent { }
    public class A153 : IComponent { }
    public class A154 : IComponent { }
    public class A155 : IComponent { }
    public class A156 : IComponent { }
    public class A157 : IComponent { }
    public class A158 : IComponent { }
    public class A159 : IComponent { }
    public class A160 : IComponent { }
    public class A161 : IComponent { }
    public class A162 : IComponent { }
    public class A163 : IComponent { }
    public class A164 : IComponent { }
    public class A165 : IComponent { }
    public class A166 : IComponent { }
    public class A167 : IComponent { }
    public class A168 : IComponent { }
    public class A169 : IComponent { }
    public class A170 : IComponent { }
    public class A171 : IComponent { }
    public class A172 : IComponent { }
    public class A173 : IComponent { }
    public class A174 : IComponent { }
    public class A175 : IComponent { }
    public class A176 : IComponent { }
    public class A177 : IComponent { }
    public class A178 : IComponent { }
    public class A179 : IComponent { }
    public class A180 : IComponent { }
    public class A181 : IComponent { }
    public class A182 : IComponent { }
    public class A183 : IComponent { }
    public class A184 : IComponent { }
    public class A185 : IComponent { }
    public class A186 : IComponent { }
    public class A187 : IComponent { }
    public class A188 : IComponent { }
    public class A189 : IComponent { }
    public class A190 : IComponent { }
    public class A191 : IComponent { }
    public class A192 : IComponent { }
    public class A193 : IComponent { }
    public class A194 : IComponent { }
    public class A195 : IComponent { }
    public class A196 : IComponent { }
    public class A197 : IComponent { }
    public class A198 : IComponent { }
    public class A199 : IComponent { }
    public class A200 : IComponent { }
    public class A201 : IComponent { }
    public class A202 : IComponent { }
    public class A203 : IComponent { }
    public class A204 : IComponent { }
    public class A205 : IComponent { }
    public class A206 : IComponent { }
    public class A207 : IComponent { }
    public class A208 : IComponent { }
    public class A209 : IComponent { }
    public class A210 : IComponent { }
    public class A211 : IComponent { }
    public class A212 : IComponent { }
    public class A213 : IComponent { }
    public class A214 : IComponent { }
    public class A215 : IComponent { }
    public class A216 : IComponent { }
    public class A217 : IComponent { }
    public class A218 : IComponent { }
    public class A219 : IComponent { }
    public class A220 : IComponent { }
    public class A221 : IComponent { }
    public class A222 : IComponent { }
    public class A223 : IComponent { }
    public class A224 : IComponent { }
    public class A225 : IComponent { }
    public class A226 : IComponent { }
    public class A227 : IComponent { }
    public class A228 : IComponent { }
    public class A229 : IComponent { }
    public class A230 : IComponent { }
    public class A231 : IComponent { }
    public class A232 : IComponent { }
    public class A233 : IComponent { }
    public class A234 : IComponent { }
    public class A235 : IComponent { }
    public class A236 : IComponent { }
    public class A237 : IComponent { }
    public class A238 : IComponent { }
    public class A239 : IComponent { }
    public class A240 : IComponent { }
    public class A241 : IComponent { }
    public class A242 : IComponent { }
    public class A243 : IComponent { }
    public class A244 : IComponent { }
    public class A245 : IComponent { }
    public class A246 : IComponent { }
    public class A247 : IComponent { }
    public class A248 : IComponent { }
    public class A249 : IComponent { }
    public class A250 : IComponent { }
    public class A251 : IComponent { }
    public class A252 : IComponent { }
    public class A253 : IComponent { }
    public class A254 : IComponent { }
    public class A255 : IComponent { }
    public class A256 : IComponent { }
    public class A257 : IComponent { }
    public class A258 : IComponent { }
    public class A259 : IComponent { }
    public class A260 : IComponent { }
    public class A261 : IComponent { }
    public class A262 : IComponent { }
    public class A263 : IComponent { }
    public class A264 : IComponent { }
    public class A265 : IComponent { }
    public class A266 : IComponent { }
    public class A267 : IComponent { }
    public class A268 : IComponent { }
    public class A269 : IComponent { }
    public class A270 : IComponent { }
    public class A271 : IComponent { }
    public class A272 : IComponent { }
    public class A273 : IComponent { }
    public class A274 : IComponent { }
    public class A275 : IComponent { }
    public class A276 : IComponent { }
    public class A277 : IComponent { }
    public class A278 : IComponent { }
    public class A279 : IComponent { }
    public class A280 : IComponent { }
    public class A281 : IComponent { }
    public class A282 : IComponent { }
    public class A283 : IComponent { }
    public class A284 : IComponent { }
    public class A285 : IComponent { }
    public class A286 : IComponent { }
    public class A287 : IComponent { }
    public class A288 : IComponent { }
    public class A289 : IComponent { }
    public class A290 : IComponent { }
    public class A291 : IComponent { }
    public class A292 : IComponent { }
    public class A293 : IComponent { }
    public class A294 : IComponent { }
    public class A295 : IComponent { }
    public class A296 : IComponent { }
    public class A297 : IComponent { }
    public class A298 : IComponent { }
    public class A299 : IComponent { }
    public class A300 : IComponent { }
    public class A301 : IComponent { }
    public class A302 : IComponent { }
    public class A303 : IComponent { }
    public class A304 : IComponent { }
    public class A305 : IComponent { }
    public class A306 : IComponent { }
    public class A307 : IComponent { }
    public class A308 : IComponent { }
    public class A309 : IComponent { }
    public class A310 : IComponent { }
    public class A311 : IComponent { }
    public class A312 : IComponent { }
    public class A313 : IComponent { }
    public class A314 : IComponent { }
    public class A315 : IComponent { }
    public class A316 : IComponent { }
    public class A317 : IComponent { }
    public class A318 : IComponent { }
    public class A319 : IComponent { }
    public class A320 : IComponent { }
    public class A321 : IComponent { }
    public class A322 : IComponent { }
    public class A323 : IComponent { }
    public class A324 : IComponent { }
    public class A325 : IComponent { }
    public class A326 : IComponent { }
    public class A327 : IComponent { }
    public class A328 : IComponent { }
    public class A329 : IComponent { }
    public class A330 : IComponent { }
    public class A331 : IComponent { }
    public class A332 : IComponent { }
    public class A333 : IComponent { }
    public class A334 : IComponent { }
    public class A335 : IComponent { }
    public class A336 : IComponent { }
    public class A337 : IComponent { }
    public class A338 : IComponent { }
    public class A339 : IComponent { }
    public class A340 : IComponent { }
    public class A341 : IComponent { }
    public class A342 : IComponent { }
    public class A343 : IComponent { }
    public class A344 : IComponent { }
    public class A345 : IComponent { }
    public class A346 : IComponent { }
    public class A347 : IComponent { }
    public class A348 : IComponent { }
    public class A349 : IComponent { }
    public class A350 : IComponent { }
    public class A351 : IComponent { }
    public class A352 : IComponent { }
    public class A353 : IComponent { }
    public class A354 : IComponent { }
    public class A355 : IComponent { }
    public class A356 : IComponent { }
    public class A357 : IComponent { }
    public class A358 : IComponent { }
    public class A359 : IComponent { }
    public class A360 : IComponent { }
    public class A361 : IComponent { }
    public class A362 : IComponent { }
    public class A363 : IComponent { }
    public class A364 : IComponent { }
    public class A365 : IComponent { }
    public class A366 : IComponent { }
    public class A367 : IComponent { }
    public class A368 : IComponent { }
    public class A369 : IComponent { }
    public class A370 : IComponent { }
    public class A371 : IComponent { }
    public class A372 : IComponent { }
    public class A373 : IComponent { }
    public class A374 : IComponent { }
    public class A375 : IComponent { }
    public class A376 : IComponent { }
    public class A377 : IComponent { }
    public class A378 : IComponent { }
    public class A379 : IComponent { }
    public class A380 : IComponent { }
    public class A381 : IComponent { }
    public class A382 : IComponent { }
    public class A383 : IComponent { }
    public class A384 : IComponent { }
    public class A385 : IComponent { }
    public class A386 : IComponent { }
    public class A387 : IComponent { }
    public class A388 : IComponent { }
    public class A389 : IComponent { }
    public class A390 : IComponent { }
    public class A391 : IComponent { }
    public class A392 : IComponent { }
    public class A393 : IComponent { }
    public class A394 : IComponent { }
    public class A395 : IComponent { }
    public class A396 : IComponent { }
    public class A397 : IComponent { }
    public class A398 : IComponent { }
    public class A399 : IComponent { }
    public class A400 : IComponent { }
}
