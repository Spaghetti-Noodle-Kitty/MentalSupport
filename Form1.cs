using System.Windows.Forms;

namespace MentalSupport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.IO.Stream str = Properties.Resources.DANCE_BITCH;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.PlayLooping();
        }
    }
}
