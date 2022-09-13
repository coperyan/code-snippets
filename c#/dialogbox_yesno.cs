if (MessageBox.Show("Are you sure you want to continue?","Confirm Selection", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes)
{
    try
    {
        RunMethod();
    }
    catch (Exception)
    {
        MessageBox.Show("Something went wrong. Dial 911.", "Error");
    }
