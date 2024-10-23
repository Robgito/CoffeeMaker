using System.Windows;

namespace Oefening_31._4
{
    internal class Koffiemachien
    {
        private int _bonen;
        private int _water;
        private int _bonenReservoir;
        private int _afvalWater;
        private int _melk;
        private int _kalkHoeveelheid;

        public delegate void KoffiemachienHandler(string Sender);

        public event KoffiemachienHandler BonenOp;
        public event KoffiemachienHandler BonenBijnaOp;
        public event KoffiemachienHandler BonenChanged;
        public event KoffiemachienHandler WaterOp;
        public event KoffiemachienHandler WaterBijnaOp;
        public event KoffiemachienHandler WaterChanged;
        public event KoffiemachienHandler MelkOp;
        public event KoffiemachienHandler MelkBijnaOp;
        public event KoffiemachienHandler MelkChanged;
        public event KoffiemachienHandler AfvalWaterVol;
        public event KoffiemachienHandler AfvalWaterBijnaVol;
        public event KoffiemachienHandler AfvalWaterChanged;
        public event KoffiemachienHandler BonenReservoirVol;
        public event KoffiemachienHandler BonenReservoirBijnaVol;
        public event KoffiemachienHandler BonenReservoirChanged;
        public event KoffiemachienHandler KalkVol;
        public event KoffiemachienHandler KalkBijnaVol;
        public event KoffiemachienHandler KalkChanged;

        public Koffiemachien()
        {
            _bonen = 100;
            _water = 100;
            _melk = 100;
            _afvalWater = 0;
            _bonenReservoir = 0;
            _kalkHoeveelheid = 0;
        }

        public int Kalkhoeveelheid
        {
            get { return _kalkHoeveelheid; }
            set
            {
                if (value <= 100)
                    {
                    _kalkHoeveelheid = value;
                    if (KalkChanged != null)
                    {
                        KalkChanged(value.ToString() + "%");
                    }

                    if (value >= 100)
                    {
                        if (KalkVol != null)
                        {
                            KalkVol("De machine moet ontkalkt worden.");
                        }
                    }
                    else if (value > 85 && value < 100)
                    {
                        if (KalkBijnaVol != null)
                        {
                            KalkBijnaVol(value.ToString() + "% (Bijna ontkalken!)");
                        }
                    }
                }
                else
                {
                    throw new System.Exception("Er kan geen koffie gemaakt worden, controleer de machine!");
                }
            }
        }

        public int Melk
        {
            get { return _melk; }
            set
            {
                if (value >= 0)
                {
                    _melk = value;
                    if (MelkChanged != null)
                    {
                        MelkChanged(value.ToString() + "%");
                    }

                    if (value <= 0)
                    {
                        if (MelkOp != null)
                        {
                            MelkOp("De melk is op, vul ze bij.");
                        }
                    }
                    else if (value > 0 && value < 15)
                    {
                        if (MelkBijnaOp != null)
                        {
                            MelkBijnaOp(value.ToString() + "% (Bijna op!)");
                        }
                    }
                }
                else 
                {
                    throw new System.Exception("Er kan geen koffie gemaakt worden, controleer de machine!");
                }
            }
        }

        public int AfvalWater
        {
            get { return _afvalWater; }
            set
            {
                if (value <= 100)
                {
                    _afvalWater = value;
                    if (AfvalWaterChanged != null)
                    {
                        AfvalWaterChanged(value.ToString() + "%");
                    }

                    if (value >= 100)
                    {
                        if (AfvalWaterVol != null)
                        {
                            AfvalWaterVol("Het afvalwater is vol, leeg het uit.");
                        }
                    }
                    else if (value > 85 && value < 100)
                    {
                        if (AfvalWaterBijnaVol != null)
                        {
                            AfvalWaterBijnaVol(value.ToString() + "% (Bijna vol!)");
                        }
                    }
                }
                else
                {
                    throw new System.Exception("Er kan geen koffie gemaakt worden, controleer de machine!");
                }
            }
        }

        public int BonenReservoir
        {
            get { return _bonenReservoir; }
            set
            {
                if (value <= 100)
                {
                    _bonenReservoir = value;
                    if (BonenReservoirChanged != null)
                    {
                        BonenReservoirChanged(value.ToString() + "%");
                    }

                    if (value >= 100)
                    {
                        if (BonenReservoirVol != null)
                        {
                            BonenReservoirVol("Het bonenreservoir is vol, leeg het uit.");
                        }
                    }
                    else if (value > 85 && value < 100)
                    {
                        if (BonenReservoirBijnaVol != null)
                        {
                            BonenReservoirBijnaVol(value.ToString() + "% (Bijna vol!)");
                        }
                    }
                }
                else
                {
                    throw new System.Exception("Er kan geen koffie gemaakt worden, controleer de machine!");
                }
            }
        }

        public int Water
        {
            get { return _water; }
            set
            {
                if (value >= 0)
                {
                    _water = value;
                    if (WaterChanged != null)
                    {
                        WaterChanged(value.ToString() + "%");
                    }

                    if (value <= 0)
                    {
                        if (WaterOp != null)
                        {
                            WaterOp("Het water is op, vul het bij.");
                        }
                    }
                    else if (value > 0 && value < 15)
                    {
                        if (WaterBijnaOp != null)
                        {
                            WaterBijnaOp(value.ToString() + "% (Bijna op!)");
                        }
                    }
                }
                else
                {
                    throw new System.Exception("Er kan geen koffie gemaakt worden, controleer de machine!");
                }
            }
        }

        public int Bonen
        {
            get { return _bonen; }
            set
            {
                if (value >= 0)
                {
                    _bonen = value;
                    if (BonenChanged != null)
                    {
                        BonenChanged(value.ToString() + "%");
                    }

                    if (value <= 0)
                    {
                        if (BonenOp != null)
                        {
                            BonenOp("De bonen zijn op, vul ze bij.");
                        }
                    }
                    else if (value > 0 && value < 15)
                    {
                        if (BonenBijnaOp != null)
                        {
                            BonenBijnaOp(value.ToString() + "% (Bijna op!)");
                        }
                    }
                }
                else
                {
                    throw new System.Exception("Er kan geen koffie gemaakt worden, controleer de machine!");
                }
            }
        }
    }
}
