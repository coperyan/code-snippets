private bool IsSelected()
{

  bool isit = True;

  if (UserControl.SelectedIndex > - 1)
  {
    isit = True;
  }
  else
  {
    isit = False;
  }

  return isit;

}
