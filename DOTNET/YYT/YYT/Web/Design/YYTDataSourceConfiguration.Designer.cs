#if !CLIENTONLY
namespace YYT.Web.Design
{
  partial class YYTDataSourceConfiguration
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YYTDataSourceConfiguration));
      this.label2 = new System.Windows.Forms.Label();
      this.okButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.TypeComboBox = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // okButton
      // 
      resources.ApplyResources(this.okButton, "okButton");
      this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.okButton.Name = "okButton";
      this.okButton.UseVisualStyleBackColor = true;
      // 
      // cancelButton
      // 
      resources.ApplyResources(this.cancelButton, "cancelButton");
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.UseVisualStyleBackColor = true;
      // 
      // TypeComboBox
      // 
      resources.ApplyResources(this.TypeComboBox, "TypeComboBox");
      this.TypeComboBox.FormattingEnabled = true;
      this.TypeComboBox.Name = "TypeComboBox";
      this.TypeComboBox.Sorted = true;
      // 
      // YYTDataSourceConfiguration
      // 
      this.AcceptButton = this.okButton;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ControlBox = false;
      this.Controls.Add(this.TypeComboBox);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.label2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "YYTDataSourceConfiguration";
      this.ShowInTaskbar = false;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.ComboBox TypeComboBox;
  }
}
#endif