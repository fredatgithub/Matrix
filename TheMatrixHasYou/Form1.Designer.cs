namespace TheMatrixHasYou
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.labelMatrix = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // labelMatrix
      // 
      this.labelMatrix.AutoSize = true;
      this.labelMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelMatrix.ForeColor = System.Drawing.Color.Green;
      this.labelMatrix.Location = new System.Drawing.Point(49, 75);
      this.labelMatrix.Name = "labelMatrix";
      this.labelMatrix.Size = new System.Drawing.Size(188, 24);
      this.labelMatrix.TabIndex = 0;
      this.labelMatrix.Text = "The matrix has you";
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 150;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.ClientSize = new System.Drawing.Size(614, 202);
      this.Controls.Add(this.labelMatrix);
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "The Matrix has you ...";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelMatrix;
    private System.Windows.Forms.Timer timer1;
  }
}

