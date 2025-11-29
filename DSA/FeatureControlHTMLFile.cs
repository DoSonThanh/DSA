using System.Text;
public class HTMLFromFile : UserControl
{
    
    private RichTextBox txtInput;
    private RichTextBox txtOutput;
    private Button btnProcess;
    private System.ComponentModel.IContainer components = null;
    public HTMLFromFile()
    {
        InitializeComponent();
        CreateUI();
        TextBox txt = new TextBox();
        txt.Text = "Hello World";
        txt.Location = new Point(20, 20);

        Controls.Add(txt);
    }
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "HTML from file directory";

        
    }

   
    private void CreateUI()
    {
        // Input TextBox
        txtInput = new RichTextBox();
        txtInput.Multiline = true;
        txtInput.ScrollBars = RichTextBoxScrollBars.Both;   // vertical + horizontal scroll
        txtInput.WordWrap = false;               // keep HTML formatting
        txtInput.Font = new Font("Times New Roman", 12); // good for coding text
        txtInput.Location = new Point(20, 20);
        txtInput.Size = new Size(350, 100);        // large area
        Controls.Add(txtInput); 

        // Output TextBox
        txtOutput = new RichTextBox();
        txtOutput.Multiline = true;
        txtOutput.ScrollBars = RichTextBoxScrollBars.Both;
        txtOutput.Location = new Point(20, 180); 
        txtOutput.Size = new Size(350, 100);  
        txtOutput.ReadOnly = true;           // Make output non-editable
        Controls.Add(txtOutput);

        // Button
        btnProcess = new Button();
        btnProcess.Text = "Process";
        btnProcess.Location = new Point(20, 130);         // Under input box
        btnProcess.Size = new Size(100, 35);
        btnProcess.Click += BtnProcess_Click;
        Controls.Add(btnProcess);
    }
    public string ReadHtmlFile(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("HTML file not found.", filePath);

            return File.ReadAllText(filePath, Encoding.UTF8);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error reading HTML file:\n" + ex.Message);
            return string.Empty;
        }
    }
    // What happens when pressing the button
    private void BtnProcess_Click(object sender, EventArgs e)
    {
        string input = txtInput.Text;
        HTMLParserSolution2 Parser = new HTMLParserSolution2();
        
        txtOutput.Text =  Parser.Parse(ReadHtmlFile(input));
    }

}

