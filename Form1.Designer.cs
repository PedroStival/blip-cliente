
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.btnRegistrarNickname = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtTextoEnvio = new System.Windows.Forms.TextBox();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            this.listUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nickname:";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(79, 6);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(269, 23);
            this.txtNickname.TabIndex = 1;
            // 
            // btnRegistrarNickname
            // 
            this.btnRegistrarNickname.Location = new System.Drawing.Point(354, 6);
            this.btnRegistrarNickname.Name = "btnRegistrarNickname";
            this.btnRegistrarNickname.Size = new System.Drawing.Size(144, 23);
            this.btnRegistrarNickname.TabIndex = 2;
            this.btnRegistrarNickname.Text = "Registrar nickname";
            this.btnRegistrarNickname.UseVisualStyleBackColor = true;
            this.btnRegistrarNickname.Click += new System.EventHandler(this.btnRegistrarNickname_Click);
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(12, 51);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(486, 324);
            this.txtChat.TabIndex = 3;
            // 
            // txtTextoEnvio
            // 
            this.txtTextoEnvio.Location = new System.Drawing.Point(12, 381);
            this.txtTextoEnvio.Multiline = true;
            this.txtTextoEnvio.Name = "txtTextoEnvio";
            this.txtTextoEnvio.Size = new System.Drawing.Size(394, 57);
            this.txtTextoEnvio.TabIndex = 4;
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.Location = new System.Drawing.Point(412, 380);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(86, 58);
            this.btnEnviarMensagem.TabIndex = 5;
            this.btnEnviarMensagem.Text = "Enviar";
            this.btnEnviarMensagem.UseVisualStyleBackColor = true;
            this.btnEnviarMensagem.Click += new System.EventHandler(this.btnEnviarMensagem_Click);
            // 
            // listUsuarios
            // 
            this.listUsuarios.FormattingEnabled = true;
            this.listUsuarios.ItemHeight = 15;
            this.listUsuarios.Location = new System.Drawing.Point(504, 51);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(205, 319);
            this.listUsuarios.TabIndex = 6;
            this.listUsuarios.SelectedIndexChanged += new System.EventHandler(this.listUsuarios_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.listUsuarios);
            this.Controls.Add(this.btnEnviarMensagem);
            this.Controls.Add(this.txtTextoEnvio);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btnRegistrarNickname);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Button btnRegistrarNickname;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtTextoEnvio;
        private System.Windows.Forms.Button btnEnviarMensagem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listUsuarios;
    }
}

