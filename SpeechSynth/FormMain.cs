using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace SpeechSynth
{
    public partial class FormMain : Form
    {
        private SpeechSynthesizer speech = new SpeechSynthesizer();
        private List<InstalledVoice> voiceList = new List<InstalledVoice>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            foreach(InstalledVoice voice in speech.GetInstalledVoices())
            {
                voiceList.Add(voice);
                comboVoiceList.Items.Add(voice.VoiceInfo.Name);
            }
            comboVoiceList.SelectedIndex = 0;

            FormatGUI(0);
        }

        private void comboVoiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatGUI(comboVoiceList.SelectedIndex);
            btnStop.PerformClick();
            speech.SelectVoice(comboVoiceList.Items[comboVoiceList.SelectedIndex].ToString());
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (checkIsSSML.Checked)
            {
                speech.SpeakSsmlAsync(richTextSpeech.Text);
            }
            else
            {
                speech.SpeakAsync(richTextSpeech.Text);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
        }

        private void FormatGUI(int idx)
        {

            var currentVoice = voiceList[idx];
            bool displayUP = checkDisplayUnknownProperties.Checked;
            labelCanBeUsed.Text = "Can be used: " + (currentVoice.Enabled ? "Yes" : "No");
            labelID.Text = "ID: " + currentVoice.VoiceInfo.Id;
            labelGender.Text = "Gender: " + currentVoice.VoiceInfo.Gender.ToString();
            labelAge.Text = "Age: " + currentVoice.VoiceInfo.Age;
            labelCulture.Text = "Culture: " + currentVoice.VoiceInfo.Culture.ToString();
            labelDescription.Text = "Description: " + currentVoice.VoiceInfo.Description;

            foreach (var pair in currentVoice.VoiceInfo.AdditionalInfo)
            {
                switch (pair.Key)
                {
                    case "Age":
                    case "Gender":
                    case "Name":
                        break;
                    case "Language":
                        labelLang.Text = "Language (LCID): " + pair.Value;
                        break;
                    case "SharedPronunciation":
                        if (pair.Value == "") break;
                        labelSharedPronunciation.Text = "Shared Pronunciation: " + pair.Value;
                        break;
                    case "Vendor":
                        labelVendor.Text = "Vendor: " + pair.Value;
                        break;
                    case "Version":
                        labelVersion.Text = "Version: " + pair.Value;
                        break;
                    default:
                        if (!displayUP) break;
                        MessageBox.Show(
                            "Key: " + pair.Key + Environment.NewLine + "Value: " + pair.Value,
                            "Unkown Property found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                }
            }
        }
    }
}
