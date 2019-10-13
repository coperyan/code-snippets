//This is in a HttpPost statement for form submission
//If message is not success
if (returnMsg != "Success")
{
    //Update model state (for form that was being submitted)
    //Change error for form item (in this case -> CustomerID)
    ModelState.AddModelError("CustomerID", returnMsg);

    //Return to the view
    return View(newCust);
}
//Otherwise...
else
{
    //Redirect normally
    return RedirectToAction("DataView", new { ID = ID });
}
