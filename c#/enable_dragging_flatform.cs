//Variables for window dragging
public const int WM_NCLBUTTONDOWN = 0xA1;
public const int HT_CAPTION = 0x2;

//Importing DLLs for window dragging
[DllImportAttribute("user32.dll")]
public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
[DllImportAttribute("user32.dll")]
public static extern bool ReleaseCapture();

private void Form1_MouseDown(object sender, MouseEventArgs e)
{
    if (e.Button == MouseButtons.Left)
    {
        ReleaseCapture();
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
    }

}