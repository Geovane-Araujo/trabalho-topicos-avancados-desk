﻿
namespace TerminalBacarioDesktop
{
    partial class form_terminal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_saldos = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btn_extratos = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.btn_transferencias = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Olá Geovane Seja bem Vindo";
            // 
            // btn_saldos
            // 
            this.btn_saldos.Location = new System.Drawing.Point(29, 165);
            this.btn_saldos.Name = "btn_saldos";
            this.btn_saldos.Size = new System.Drawing.Size(373, 59);
            this.btn_saldos.TabIndex = 1;
            this.btn_saldos.Text = "Saldos (F6)";
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(460, 165);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(373, 59);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Saques (F9)";
            // 
            // btn_extratos
            // 
            this.btn_extratos.Location = new System.Drawing.Point(29, 283);
            this.btn_extratos.Name = "btn_extratos";
            this.btn_extratos.Size = new System.Drawing.Size(373, 59);
            this.btn_extratos.TabIndex = 3;
            this.btn_extratos.Text = "Extratos  (F7)";
            this.btn_extratos.Click += new System.EventHandler(this.btn_extratos_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton4.Location = new System.Drawing.Point(460, 283);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(373, 59);
            this.metroButton4.TabIndex = 4;
            this.metroButton4.Text = "Pix";
            // 
            // metroButton5
            // 
            this.metroButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton5.Location = new System.Drawing.Point(460, 401);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(373, 59);
            this.metroButton5.TabIndex = 6;
            this.metroButton5.Text = "Segurança";
            // 
            // btn_transferencias
            // 
            this.btn_transferencias.Location = new System.Drawing.Point(29, 401);
            this.btn_transferencias.Name = "btn_transferencias";
            this.btn_transferencias.Size = new System.Drawing.Size(373, 59);
            this.btn_transferencias.TabIndex = 5;
            this.btn_transferencias.Text = "Transferencias (F8)";
            // 
            // form_terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(856, 523);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.btn_transferencias);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.btn_extratos);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btn_saldos);
            this.Controls.Add(this.label1);
            this.Name = "form_terminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Terminal Bancario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btn_saldos;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btn_extratos;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton btn_transferencias;
    }
}

