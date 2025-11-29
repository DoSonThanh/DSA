using DSA;
using FeatureControlHTMLtext;
public class FeatureSelectionForm : Form
{
    private System.ComponentModel.IContainer components = null;
    private Panel containerPanel;

    public FeatureSelectionForm()
    {
        InitializeComponent();
        CreateMenu();
        CreateContainer();
    }

    private void CreateMenu()
    {
        // Button 1
        Button btnOption1 = new Button();
        btnOption1.Text = "HTML From Text";
        btnOption1.Location = new Point(30, 30);
        btnOption1.Size = new Size(150, 40);
        btnOption1.Click += BtnOption1_Click;
        Controls.Add(btnOption1);

        // Button 2
        Button btnOption2 = new Button();
        btnOption2.Text = "HTML From File";
        btnOption2.Location = new Point(250, 30);
        btnOption2.Size = new Size(150, 40);
        btnOption2.Click += BtnOption2_Click;
        Controls.Add(btnOption2);

    }

    private void BtnOption1_Click(object sender, EventArgs e)
    {
        LoadFeature(new HTMLFromWords());

    }
    private void LoadFeature(UserControl control)
    {
        containerPanel.Controls.Clear();        // remove old page
        control.Dock = DockStyle.Fill;          // make it fill the area
        containerPanel.Controls.Add(control);   // load new page
    }
    private void BtnOption2_Click(object sender, EventArgs e)
    {
        LoadFeature(new HTMLFromFile());

    }
    private void CreateContainer()
    {
        containerPanel = new Panel();
        containerPanel.Location = new Point(20, 70);
        containerPanel.Size = new Size(700, 400);
        containerPanel.BorderStyle = BorderStyle.FixedSingle;

        Controls.Add(containerPanel);
    }
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Feature Selection";

        
    }
  
}