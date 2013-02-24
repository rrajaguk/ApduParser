using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParserLib;
using ParserLib.SMS;

namespace APDUTest
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
      public class ProactiveCommandTest
      {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void TestNormalProactive()
        {
            var PC = new Envelope();
            //PC.parseEnvelope("D1 81 AA 82 02 83 81 06 06 91 53 84 09 10 00 8B 81 9B 44 04 81 97 16 7F F6 21 21 81 01 02 50 00 8C 02 70 00 00 87 15 12 29 00 10 4F 53 4D 00 00 00 03 FA 00 A7 C9 8A 62 EC 13 DA 2E 80 50 30 00 08 08 07 06 05 04 03 02 01 84 82 03 00 10 B8 8F C2 D6 0E D1 51 49 77 57 03 24 3D E2 00 98 84 E6 20 00 28 0B 07 20 83 FE F7 6E E3 40 36 FB DB AD AC 81 C7 B3 CB 3A A7 D0 F7 6B D1 14 A7 00 B7 01 B3 A5 62 9A 3C 09 D8 3D 8D 86 6A 84 E2 91 00 18 3F 26 AD CE 0D FF D1 FB 7F 42 14 95 0C F3 EB D0 D6 FA A5 1B 6B AD F4 AF 00 C0 00 00 00");
            PC.parseEnvelope("D0 55 81 03 01 13 00 82 02 81 83 85 00 86 06 91 53 84 09 10 00 8B 40 41 00 04 81 97 16 00 F6 37 02 71 00 00 32 12 4F 53 4D 00 00 00 03 FA 00 00 94 EE 25 4A 95 0D AB 30 05 90 00 55 1A 11 10 00 00 00 00 00 00 00 00 00 00 00 00 00 01 01 08 29 47 10 02 10 00 80 09");
        }      
      }
}
