using TRPOPractic.Lib;

namespace TRPO_Practic_Tests

{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OmegaE_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.OmegaE, Is.EqualTo(6.330255116d).Within(0.000000001));
        }
        [Test]
        public void Vf_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.Vf, Is.EqualTo(0.0000042082d).Within(0.0000001));
        }
        [Test]
        public void Kf_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.Kf, Is.EqualTo(0.171881368d).Within(0.000000001));
        }
        [Test]
        public void Af_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.Af, Is.EqualTo(4.089945853d).Within(0.00000001));//4,08932715
        }

        [Test]
        public void R_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.R, Is.EqualTo(0.73722366d).Within(0.000000001));
        }
        [Test]
        public void D_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.D, Is.EqualTo(0.363762737d).Within(0.00000001));
        }

        [Test]
        public void d0_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.d0, Is.EqualTo(0.002219107d).Within(0.000000001));
        }
        [Test]
        public void ReE_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.ReE, Is.EqualTo(2517.47436d).Within(0.0001));
        }

        [Test]
        public void Fvh_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.Fvh, Is.EqualTo(0.000314159d).Within(0.000000001));
        }

        [Test]
        public void H_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.H, Is.EqualTo(0.024d).Within(0.000000001));
        }
        [Test]
        public void Nf_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.Nf, Is.EqualTo(8079.462134d).Within(0.000001));
        }
        [Test]
        public void Nfr_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.Nfr, Is.EqualTo(2019.865533d).Within(0.000001));
        }

        [Test]
        public void f_Test()
        {
            var Vj = 0.034d;
            var Pj = 20000d;
            var a = 120;
            var dvh = 0.02d;
            var Muj = 0.001004d;
            var nf = (byte)2;
            var np = (byte)4;
            var pj = 998.2d;
            var dk = 0.0004d;

            var raslib = new RasLib(Vj, Pj, a, dvh, Muj, nf, np, pj, dk);

            Assert.That(raslib.f, Is.EqualTo(0.364243716d).Within(0.000000001));
        }
    }
}