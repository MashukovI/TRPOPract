namespace TRPOPractic.Lib
{
    public class RasLib
    {                 
        public RasLib(double Vj, double Pj, double a, double dvh, double Muj, byte nf, double np, double pj, double dk)
        {
            if (Vj < 0 || Pj < 0 || a < 0 || dvh < 0 || Muj < 0 || nf < 0 || np < 0 || pj < 0 || dk < 0)
            {
                throw new Exception("Параметры не должны быть меньше 0");
            }
            if (f < 0 || f > 1)
            {
                throw new Exception("[0-1]");
            }
            _Vj = Vj;
            _Pj = Pj;
            _a = a;
            _dvh = dvh;
            _Muj = Muj;
            _nf = nf;
            _np = np;
            _pj = pj;
            _dk = dk;
        }

        private readonly double _Vj;
        private readonly double _Pj;                                                                        
        private readonly double _a;                                        
        private readonly double _dvh;                                     
        private readonly double _Muj;                                      
        private readonly byte _nf;                        
        private readonly double _np;
        private readonly double _pj;
        private readonly double _dk;

        public double Omega => 4d * _Vj / (Math.PI * d0 * d0 * f);
        public double OmegaE => Math.Sqrt(2d * _Pj / _pj); //6,330255116
        public double Vf => Kf * Math.PI * d0 * d0 * OmegaE / 4d; //4,2082E-06
        public double Kf => 1d / Math.Sqrt(Af * Af / (1d - f) + (1d / Math.Pow(f, 2d)));
        public double Af => (1d - f) * Math.Sqrt(2d) / f / Math.Sqrt(f);
        public double R => Af * _nf * _dvh * _dvh / (2d * d0);
        public double D => (2d * Kf) + _dvh;
        public double d0 => _dk / (18.3d / Math.Pow(ReE, 0.59d));
        public double ReE => OmegaE * _dk * _pj / _Muj;
        public double Fvh => Math.PI * _dvh * _dvh / 4d;
        public double H => 1.2d * _dvh;
        public double Nf => _Vj / Vf;
        public double Nfreal => Nfrreal*_np;
        public double Nfr => Nf / _np;
        public double Nfrreal => Math.Truncate(Nfr);
        public double f => 1d - (0.001134d * Math.Pow(_a, 1.322d));
        public double Vfreal => Nfrreal * Vf;
    }
}
//var Vj = 0.034d;
//var Pj = 20000d;
//var a = 120;
//var dvh = 0.02d;
//var Muj = 0.001004d;
//var nf = (byte)2;
//var np = (byte)4;
//var pj = 998.2d;
//var dk = 0.0004d;