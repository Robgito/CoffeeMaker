using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oefening_31._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Koffiemachien koffiemachien;
        Koffiemachien temp;
        bool machienAan = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            imgMachien.Source = new BitmapImage(new Uri("/images/coffeemachine.png", UriKind.Relative));
            koffiemachien = new Koffiemachien();
            koffiemachien.AfvalWaterBijnaVol += Koffiemachien_AfvalWaterBijnaVol;
            koffiemachien.AfvalWaterChanged += Koffiemachien_AfvalWaterChanged;
            koffiemachien.AfvalWaterVol += Koffiemachien_AfvalWaterVol;
            koffiemachien.WaterChanged += Koffiemachien_WaterChanged;
            koffiemachien.WaterBijnaOp += Koffiemachien_WaterBijnaOp;
            koffiemachien.WaterOp += Koffiemachien_WaterOp;
            koffiemachien.MelkChanged += Koffiemachien_MelkChanged;
            koffiemachien.MelkBijnaOp += Koffiemachien_MelkBijnaOp;
            koffiemachien.MelkOp += Koffiemachien_MelkOp;
            koffiemachien.BonenOp += Koffiemachien_BonenOp;
            koffiemachien.BonenBijnaOp += Koffiemachien_BonenBijnaOp;
            koffiemachien.BonenChanged += Koffiemachien_BonenChanged;
            koffiemachien.KalkChanged += Koffiemachien_KalkChanged;
            koffiemachien.KalkVol += Koffiemachien_KalkVol;
            koffiemachien.KalkBijnaVol += Koffiemachien_KalkBijnaVol;
            koffiemachien.BonenReservoirBijnaVol += Koffiemachien_BonenReservoirBijnaVol;
            koffiemachien.BonenReservoirChanged += Koffiemachien_BonenReservoirChanged;
            koffiemachien.BonenReservoirVol += Koffiemachien_BonenReservoirVol;
            LabelsUpdaten();
        }

        private void LabelsUpdaten()
        {
            lblBonen.Content = "Bonen: " + koffiemachien.Bonen + "%";
            lblWater.Content = "Water: " + koffiemachien.Water + "%";
            lblMelk.Content = "Melk: " + koffiemachien.Melk + "%";
            lblAfvalWater.Content = "Afvalwater: " + koffiemachien.AfvalWater + "%";
            lblBonenReservoir.Content = "Bonenreservoir: " + koffiemachien.BonenReservoir + "%";
            lblKalk.Content = "Kalk: " + koffiemachien.Kalkhoeveelheid + "%";
        }
        //Events
        private void Koffiemachien_BonenReservoirVol(string Sender)
        {
            lblBonenReservoir.Content = "Bonenreservoir: " + Sender;
        }

        private void Koffiemachien_BonenReservoirChanged(string Sender)
        {
            lblBonenReservoir.Content = "Bonenreservoir: " + Sender;
        }

        private void Koffiemachien_BonenReservoirBijnaVol(string Sender)
        {
            lblBonenReservoir.Content = "Bonenreservoir: " + Sender;
        }

        private void Koffiemachien_KalkBijnaVol(string Sender)
        {
            lblKalk.Content = "Kalk: " + Sender;
        }

        private void Koffiemachien_KalkVol(string Sender)
        {
            lblKalk.Content = "Kalk: " + Sender;
        }

        private void Koffiemachien_KalkChanged(string Sender)
        {
            lblKalk.Content = "Kalk: " + Sender;
        }

        private void Koffiemachien_BonenChanged(string Sender)
        {
            lblBonen.Content = "Bonen: " + Sender;
        }

        private void Koffiemachien_BonenBijnaOp(string Sender)
        {
            lblBonen.Content = "Bonen: " + Sender;
        }

        private void Koffiemachien_BonenOp(string Sender)
        {
            lblBonen.Content = "Bonen: " + Sender;
        }

        private void Koffiemachien_MelkOp(string Sender)
        {
            lblMelk.Content = "Melk: " + Sender;
        }

        private void Koffiemachien_MelkBijnaOp(string Sender)
        {
            lblMelk.Content = "Melk: " + Sender;
        }

        private void Koffiemachien_MelkChanged(string Sender)
        {
            lblMelk.Content = "Melk: " + Sender;
        }

        private void Koffiemachien_WaterOp(string Sender)
        {
            lblWater.Content = "Water: " + Sender;
        }

        private void Koffiemachien_WaterBijnaOp(string Sender)
        {
            lblWater.Content = "Water: " + Sender;
        }

        private void Koffiemachien_WaterChanged(string Sender)
        {
            lblWater.Content = "Water: " + Sender;
        }

        private void Koffiemachien_AfvalWaterVol(string Sender)
        {
            lblAfvalWater.Content = "Afvalwater: " + Sender;
        }

        private void Koffiemachien_AfvalWaterChanged(string Sender)
        {
            lblAfvalWater.Content = "Afvalwater: " + Sender;
        }

        private void Koffiemachien_AfvalWaterBijnaVol(string Sender)
        {
            lblAfvalWater.Content = "Afvalwater: " + Sender;
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        //Koffies maken
        private void btnCoffee_Click(object sender, RoutedEventArgs e)
        {
            if (machienAan == false)
            {
                MessageBox.Show("Zet eerst de machine aan.");
            }
            else
            {
                try
                {
                    temp = new Koffiemachien();
                    temp.Bonen = koffiemachien.Bonen;
                    temp.Water = koffiemachien.Water;
                    temp.Melk = koffiemachien.Melk;
                    temp.Kalkhoeveelheid = koffiemachien.Kalkhoeveelheid;
                    temp.BonenReservoir = koffiemachien.BonenReservoir;
                    temp.AfvalWater = koffiemachien.AfvalWater;
                    temp.Bonen -= 2;
                    temp.Water -= 5;
                    temp.Melk -= 1;
                    temp.AfvalWater += 2;
                    temp.BonenReservoir += 2;
                    temp.Kalkhoeveelheid += 1;
                    koffiemachien.Bonen = temp.Bonen;
                    koffiemachien.Water = temp.Water;
                    koffiemachien.Melk = temp.Melk;
                    koffiemachien.Kalkhoeveelheid = temp.Kalkhoeveelheid;
                    koffiemachien.BonenReservoir = temp.BonenReservoir;
                    koffiemachien.AfvalWater = temp.AfvalWater;
                    SoundPlayer player = new SoundPlayer(@"Sounds\KoffieUitgieten.wav");
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEspresso_Click(object sender, RoutedEventArgs e)
        {
            if (machienAan == false)
            {
                MessageBox.Show("Zet eerst de machine aan.");
            }
            else
            {
                try
                {
                    temp = new Koffiemachien();
                    temp.Bonen = koffiemachien.Bonen;
                    temp.Water = koffiemachien.Water;
                    temp.Melk = koffiemachien.Melk;
                    temp.Kalkhoeveelheid = koffiemachien.Kalkhoeveelheid;
                    temp.BonenReservoir = koffiemachien.BonenReservoir;
                    temp.AfvalWater = koffiemachien.AfvalWater;
                    temp.Bonen -= 3;
                    temp.Water -= 5;
                    temp.Melk -= 1;
                    temp.AfvalWater += 2;
                    temp.BonenReservoir += 3;
                    temp.Kalkhoeveelheid += 1;
                    koffiemachien.Bonen = temp.Bonen;
                    koffiemachien.Water = temp.Water;
                    koffiemachien.Melk = temp.Melk;
                    koffiemachien.Kalkhoeveelheid = temp.Kalkhoeveelheid;
                    koffiemachien.BonenReservoir = temp.BonenReservoir;
                    koffiemachien.AfvalWater = temp.AfvalWater;
                    SoundPlayer player = new SoundPlayer(@"Sounds\KoffieUitgieten.wav");
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnDubbeleEspresso_Click(object sender, RoutedEventArgs e)
        {
            if (machienAan == false)
            {
                MessageBox.Show("Zet eerst de machine aan.");
            }
            else
            {
                try
                {
                    temp = new Koffiemachien();
                    temp.Bonen = koffiemachien.Bonen;
                    temp.Water = koffiemachien.Water;
                    temp.Melk = koffiemachien.Melk;
                    temp.Kalkhoeveelheid = koffiemachien.Kalkhoeveelheid;
                    temp.BonenReservoir = koffiemachien.BonenReservoir;
                    temp.AfvalWater = koffiemachien.AfvalWater;
                    temp.Bonen -= 6;
                    temp.Water -= 5;
                    temp.Melk -= 1;
                    temp.AfvalWater += 2;
                    temp.BonenReservoir += 6;
                    temp.Kalkhoeveelheid += 1;
                    koffiemachien.Bonen = temp.Bonen;
                    koffiemachien.Water = temp.Water;
                    koffiemachien.Melk = temp.Melk;
                    koffiemachien.Kalkhoeveelheid = temp.Kalkhoeveelheid;
                    koffiemachien.BonenReservoir = temp.BonenReservoir;
                    koffiemachien.AfvalWater = temp.AfvalWater;
                    SoundPlayer player = new SoundPlayer(@"Sounds\KoffieUitgieten.wav");
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnLateMachiato_Click(object sender, RoutedEventArgs e)
        {
            if (machienAan == false)
            {
                MessageBox.Show("Zet eerst de machine aan.");
            }
            else
            {
                try
                {
                    temp = new Koffiemachien();
                    temp.Bonen = koffiemachien.Bonen;
                    temp.Water = koffiemachien.Water;
                    temp.Melk = koffiemachien.Melk;
                    temp.Kalkhoeveelheid = koffiemachien.Kalkhoeveelheid;
                    temp.BonenReservoir = koffiemachien.BonenReservoir;
                    temp.AfvalWater = koffiemachien.AfvalWater;
                    temp.Bonen -= 2;
                    temp.Water -= 5;
                    temp.Melk -= 3;
                    temp.AfvalWater += 2;
                    temp.BonenReservoir += 2;
                    temp.Kalkhoeveelheid += 1;
                    koffiemachien.Bonen = temp.Bonen;
                    koffiemachien.Water = temp.Water;
                    koffiemachien.Melk = temp.Melk;
                    koffiemachien.Kalkhoeveelheid = temp.Kalkhoeveelheid;
                    koffiemachien.BonenReservoir = temp.BonenReservoir;
                    koffiemachien.AfvalWater = temp.AfvalWater;
                    SoundPlayer player = new SoundPlayer(@"Sounds\KoffieUitgieten.wav");
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        //Machine bijvullen of legen
        private void btnBonenVullen_Click(object sender, RoutedEventArgs e)
        {
            if (machienAan)
            {
                MessageBox.Show("Zet eerst de machine uit.");
            }
            else
            {
                koffiemachien.Bonen = 100;
                SoundPlayer player = new SoundPlayer(@"Sounds\Bonen.wav");
                player.Play();
                MessageBox.Show("De bonen werden bijgevuld.");
            }

        }

        private void btnMelkVullen_Click(object sender, RoutedEventArgs e)
        {
            if (machienAan)
            {
                MessageBox.Show("Zet eerst de machine uit.");
            }
            else
            {
                koffiemachien.Melk = 100;
                SoundPlayer player = new SoundPlayer(@"Sounds\Water.wav");
                player.Play();
                MessageBox.Show("De melk werd bijgevuld.");
            }
        }

        private void btnWaterVullen_Click(object sender, RoutedEventArgs e)
        {
            if (machienAan)
            {
                MessageBox.Show("Zet eerst de machine uit.");
            }
            else
            {
                koffiemachien.Water = 100;
                SoundPlayer player = new SoundPlayer(@"Sounds\Water.wav");
                player.Play();
                MessageBox.Show("Het water werd bijgevuld");
            }
        }

        private void btnOntkalken_Click(object sender, RoutedEventArgs e)
        {
            if (machienAan)
            {
                MessageBox.Show("Zet eerst de machine uit.");
            }
            else
            {
                koffiemachien.Kalkhoeveelheid = 0;
                SoundPlayer player = new SoundPlayer(@"Sounds\Ontkalken.wav");
                player.Play();
                MessageBox.Show("De machine werd ontkalkt.");
            }
        }

        private void btnAfvalwaterLegen_Click(object sender, RoutedEventArgs e)
        {
            if (machienAan)
            {
                MessageBox.Show("Zet eerst de machine uit.");
            }
            else
            {
                koffiemachien.AfvalWater = 0;
                SoundPlayer player = new SoundPlayer(@"Sounds\Water.wav");
                player.Play();
                MessageBox.Show("Het afvalwater werd geleegd.");
            }
        }

        private void btnBonenreservoirLegen_Click(object sender, RoutedEventArgs e)
        {
            if (machienAan)
            {
                MessageBox.Show("Zet eerst de machine uit.");
            }
            else
            {
                koffiemachien.BonenReservoir = 0;
                SoundPlayer player = new SoundPlayer(@"Sounds\Bonen.wav");
                player.Play();
                MessageBox.Show("Het bonenreservoir werd geleegd.");
            }
        }
        //Aan-uit knop
        private void btnOnOff_Click(object sender, RoutedEventArgs e)
        {
            if (machienAan == false)
            {
                machienAan = true;
                btnOnOff.Content = "ON";
                btnOnOff.Background = Brushes.Blue;
            }
            else
            {
                machienAan = false;
                btnOnOff.Content = "OFF";
                btnOnOff.Background = Brushes.White;
            }
        }
        //Venster slepen
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
