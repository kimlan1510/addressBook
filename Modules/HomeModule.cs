using Nancy;
using System.Collections.Generic;
using addressBook.Objects;

namespace addressBook
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<contact> allContact = contact.ShowAll();
        return View["index.cshtml", allContact];
      };

      Get["/contact/{id}"] = parameters => {
        contact foundContact = contact.Find(parameters.id);
        return View["contact_info.cshtml", foundContact];
      };

      Get["/contact"] = _ => View["contact_form.cshtml"];

      Post["/contact/new"] = _ => {
        contact newContact = new contact(Request.Form["name"], Request.Form["phone#"], Request.Form["address"]);
        return View["contact_new.cshtml", newContact];
      };

      Post["contact/clear"] = _ => {
        contact.ClearAll();
        return View["contact_cleared.cshtml"];
      };

    }
  }
}
