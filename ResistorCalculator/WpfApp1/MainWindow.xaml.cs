using ResistorCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int firstBandTapCount = 0;
        private int secondBandTapCount = 0;
        private int thirdBandTapCount = 0;
        private int fourthBandTapCount = 0;

        private BandColor FirstColorValue = new BandColor { Color = "Beige" };
        public MainWindow()
        {
            InitializeComponent();
            Lists = new BandColors();
        }
        public BandColor FirstColor
        {
            get => FirstColorValue;
            set
            {
                this.FirstColorValue = value;
                this.CalculateOhm();
            }
        }

        private BandColor SecondColorValue = new BandColor { Color = "Beige" };

        public BandColor SecondColor
        {
            get => SecondColorValue;
            set
            {
                this.SecondColorValue = value;
                this.CalculateOhm();
            }
        }

        private BandColor ThirdColorValue = new BandColor { Color = "Beige" };

        public BandColor ThirdColor
        {
            get => ThirdColorValue;
            set
            {
                this.ThirdColorValue = value;
                this.CalculateOhm();
            }
        }

        private BandColor FourthColorValue = new BandColor { Color = "Beige" };

        public BandColor FourthColor
        {
            get => FourthColorValue;
            set
            {
                this.FourthColorValue = value;
                this.CalculateOhm();
            }
        }

        private long ValueValue = 0;
        public long Value
        {
            get => ValueValue;
            set
            {
                ValueValue = value;
            }
        }

        public BandColors Lists { get; set; }

        private void CalculateOhm()
        {
            if (FirstColor != null && SecondColor != null && ThirdColor != null && FourthColor != null)
            {
                Value = (FirstColor.Value * 10 + SecondColor.Value) * ThirdColor.Value;
            }
        }

        private void FirstBand_Tapped(object sender, EventArgs e)
        {
            firstBandTapCount++;
            FirstColor = Lists.FirstBandList[firstBandTapCount % Lists.FirstBandList.Count];
        }

        private void SecondBand_Tapped(object sender, EventArgs e)
        {
            secondBandTapCount++;
            SecondColor = Lists.SecondBandList[secondBandTapCount % Lists.SecondBandList.Count];
        }

        private void ThirdBand_Tapped(object sender, EventArgs e)
        {
            thirdBandTapCount++;
            ThirdColor = Lists.ThirdBandList[thirdBandTapCount % Lists.ThirdBandList.Count];
        }

        private void FourthBand_Tapped(object sender, EventArgs e)
        {
            fourthBandTapCount++;
            FourthColor = Lists.FourthBandList[fourthBandTapCount % Lists.FourthBandList.Count];
        }
        
    }
}
