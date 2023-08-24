namespace SpeechSynth
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboVoiceList = new System.Windows.Forms.ComboBox();
            this.labelVoiceSelection = new System.Windows.Forms.Label();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupVoiceInfo = new System.Windows.Forms.GroupBox();
            this.labelVendor = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelSharedPronunciation = new System.Windows.Forms.Label();
            this.labelLang = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCulture = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCanBeUsed = new System.Windows.Forms.Label();
            this.checkIsSSML = new System.Windows.Forms.CheckBox();
            this.checkDisplayUnknownProperties = new System.Windows.Forms.CheckBox();
            this.richTextSpeech = new System.Windows.Forms.RichTextBox();
            this.groupVoiceInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboVoiceList
            // 
            this.comboVoiceList.FormattingEnabled = true;
            this.comboVoiceList.Location = new System.Drawing.Point(108, 9);
            this.comboVoiceList.Name = "comboVoiceList";
            this.comboVoiceList.Size = new System.Drawing.Size(150, 21);
            this.comboVoiceList.TabIndex = 0;
            this.comboVoiceList.SelectedIndexChanged += new System.EventHandler(this.comboVoiceList_SelectedIndexChanged);
            // 
            // labelVoiceSelection
            // 
            this.labelVoiceSelection.AutoSize = true;
            this.labelVoiceSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoiceSelection.Location = new System.Drawing.Point(12, 9);
            this.labelVoiceSelection.Name = "labelVoiceSelection";
            this.labelVoiceSelection.Size = new System.Drawing.Size(90, 17);
            this.labelVoiceSelection.TabIndex = 1;
            this.labelVoiceSelection.Text = "Select Voice:";
            // 
            // btnSpeak
            // 
            this.btnSpeak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpeak.Location = new System.Drawing.Point(225, 304);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(75, 23);
            this.btnSpeak.TabIndex = 2;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(306, 304);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Cancel Speech";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupVoiceInfo
            // 
            this.groupVoiceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupVoiceInfo.Controls.Add(this.labelVendor);
            this.groupVoiceInfo.Controls.Add(this.labelVersion);
            this.groupVoiceInfo.Controls.Add(this.labelSharedPronunciation);
            this.groupVoiceInfo.Controls.Add(this.labelLang);
            this.groupVoiceInfo.Controls.Add(this.labelDescription);
            this.groupVoiceInfo.Controls.Add(this.labelCulture);
            this.groupVoiceInfo.Controls.Add(this.labelAge);
            this.groupVoiceInfo.Controls.Add(this.labelGender);
            this.groupVoiceInfo.Controls.Add(this.labelID);
            this.groupVoiceInfo.Controls.Add(this.labelCanBeUsed);
            this.groupVoiceInfo.Location = new System.Drawing.Point(15, 66);
            this.groupVoiceInfo.Name = "groupVoiceInfo";
            this.groupVoiceInfo.Size = new System.Drawing.Size(381, 106);
            this.groupVoiceInfo.TabIndex = 5;
            this.groupVoiceInfo.TabStop = false;
            this.groupVoiceInfo.Text = "Voice Info";
            // 
            // labelVendor
            // 
            this.labelVendor.AutoSize = true;
            this.labelVendor.Location = new System.Drawing.Point(6, 33);
            this.labelVendor.Name = "labelVendor";
            this.labelVendor.Size = new System.Drawing.Size(67, 13);
            this.labelVendor.TabIndex = 9;
            this.labelVendor.Text = "Vendor: N/A";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(163, 33);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(68, 13);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.Text = "Version: N/A";
            // 
            // labelSharedPronunciation
            // 
            this.labelSharedPronunciation.AutoSize = true;
            this.labelSharedPronunciation.Location = new System.Drawing.Point(6, 72);
            this.labelSharedPronunciation.Name = "labelSharedPronunciation";
            this.labelSharedPronunciation.Size = new System.Drawing.Size(135, 13);
            this.labelSharedPronunciation.TabIndex = 7;
            this.labelSharedPronunciation.Text = "Shared Pronunciation: N/A";
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Location = new System.Drawing.Point(252, 59);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(114, 13);
            this.labelLang.TabIndex = 6;
            this.labelLang.Text = "Language (LCID): N/A";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(6, 85);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(86, 13);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Description: N/A";
            // 
            // labelCulture
            // 
            this.labelCulture.AutoSize = true;
            this.labelCulture.Location = new System.Drawing.Point(7, 59);
            this.labelCulture.Name = "labelCulture";
            this.labelCulture.Size = new System.Drawing.Size(66, 13);
            this.labelCulture.TabIndex = 4;
            this.labelCulture.Text = "Culture: N/A";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(305, 20);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(52, 13);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age: N/A";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(163, 20);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(68, 13);
            this.labelGender.TabIndex = 2;
            this.labelGender.Text = "Gender: N/A";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(6, 46);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(44, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID: N/A";
            // 
            // labelCanBeUsed
            // 
            this.labelCanBeUsed.AutoSize = true;
            this.labelCanBeUsed.Location = new System.Drawing.Point(7, 20);
            this.labelCanBeUsed.Name = "labelCanBeUsed";
            this.labelCanBeUsed.Size = new System.Drawing.Size(93, 13);
            this.labelCanBeUsed.TabIndex = 0;
            this.labelCanBeUsed.Text = "Can be used: N/A";
            // 
            // checkIsSSML
            // 
            this.checkIsSSML.AutoSize = true;
            this.checkIsSSML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIsSSML.Location = new System.Drawing.Point(270, 39);
            this.checkIsSSML.Name = "checkIsSSML";
            this.checkIsSSML.Size = new System.Drawing.Size(120, 21);
            this.checkIsSSML.TabIndex = 6;
            this.checkIsSSML.Text = "Is SSML (XML)";
            this.checkIsSSML.UseVisualStyleBackColor = true;
            // 
            // checkDisplayUnknownProperties
            // 
            this.checkDisplayUnknownProperties.AutoSize = true;
            this.checkDisplayUnknownProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisplayUnknownProperties.Location = new System.Drawing.Point(15, 36);
            this.checkDisplayUnknownProperties.Name = "checkDisplayUnknownProperties";
            this.checkDisplayUnknownProperties.Size = new System.Drawing.Size(243, 21);
            this.checkDisplayUnknownProperties.TabIndex = 7;
            this.checkDisplayUnknownProperties.Text = "Show \"Unknown Property\" Popups";
            this.checkDisplayUnknownProperties.UseVisualStyleBackColor = true;
            // 
            // richTextSpeech
            // 
            this.richTextSpeech.AcceptsTab = true;
            this.richTextSpeech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextSpeech.DetectUrls = false;
            this.richTextSpeech.Location = new System.Drawing.Point(15, 178);
            this.richTextSpeech.Name = "richTextSpeech";
            this.richTextSpeech.Size = new System.Drawing.Size(381, 120);
            this.richTextSpeech.TabIndex = 8;
            this.richTextSpeech.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 339);
            this.Controls.Add(this.richTextSpeech);
            this.Controls.Add(this.checkDisplayUnknownProperties);
            this.Controls.Add(this.checkIsSSML);
            this.Controls.Add(this.groupVoiceInfo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.labelVoiceSelection);
            this.Controls.Add(this.comboVoiceList);
            this.Name = "FormMain";
            this.Text = "Speech Synth";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupVoiceInfo.ResumeLayout(false);
            this.groupVoiceInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboVoiceList;
        private System.Windows.Forms.Label labelVoiceSelection;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupVoiceInfo;
        private System.Windows.Forms.CheckBox checkIsSSML;
        private System.Windows.Forms.Label labelCanBeUsed;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelCulture;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.Label labelSharedPronunciation;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelVendor;
        private System.Windows.Forms.CheckBox checkDisplayUnknownProperties;
        private System.Windows.Forms.RichTextBox richTextSpeech;
    }
}

