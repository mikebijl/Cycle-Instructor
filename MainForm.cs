using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.Text.Json;

namespace CycleInstructor
{
    public partial class MainForm : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            // Create OpenFileDialog to select .ci files and read them as a json file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Cycle Instructor Files|*.ci";
            openFileDialog.Title = "Select a Cycle Instructor File";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = false;

            // After the user selected a file, set the filename only as value of the label
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // use the filename only without the path
                labelTrainingFile.Text = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);

            }
            else
            {
                labelTrainingFile.Text = "";
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void buttonPlayMusic_Click(object sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(@"C:\Users\mikeb\OneDrive - Compower.org\music\_CycleMusic\_AudacityProjectFiles\MyFirstSpinningPlaylist.mp3");
                outputDevice.Init(audioFile);
            }

            if (this.outputDevice.PlaybackState == PlaybackState.Stopped || this.outputDevice.PlaybackState == PlaybackState.Paused)
            {
                outputDevice.Play();
            } else if (this.outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
            }

        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }

        public class Training 
        {
            public string name;
            public string audioFile;
            public Array[] stages;
        }

    }
}
