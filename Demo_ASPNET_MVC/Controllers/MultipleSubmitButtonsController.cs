using Microsoft.AspNetCore.Mvc;

namespace Demo_ASPNET_MVC.Controllers
{
    public class MultipleSubmitButtonsController : Controller
    {
        public IActionResult MultipleSubmitButtons()
        {
            return View();
        }

        #region With Different Submit Buttons Names
        public IActionResult WithDifferentSubmitButtonsNames()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WithDifferentSubmitButtonsNames(string save, string cancel)
        {
            if (!string.IsNullOrEmpty(save))
            {
                ViewBag.Message = "Save button clicked successfully!";
            }
            if (!string.IsNullOrEmpty(cancel))
            {
                ViewBag.Message = "Cancel button clicked successfully!";
            }

            return View();
        }
        #endregion

        #region With Same Submit Buttons Names
        public IActionResult WithSameSubmitButtonsNames()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WithSameSubmitButtonsNames(string submit)
        {
            switch (submit)
            {
                case "Save":
                    ViewBag.Message = "Save button clicked successfully!";
                    break;
                case "Cancel":
                    ViewBag.Message = "Cancel button clicked successfully!";
                    break;
            }

            return View();
        }
        #endregion

        #region With FormAction and FormMethod HTML5 Attributes
        public IActionResult WithFormActionAndFormMethodHTML5Attributes()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveForm()
        {
            ViewBag.Message = "Save button clicked successfully!";
            return View("WithFormActionAndFormMethodHTML5Attributes");
        }

        [HttpPost]
        public ActionResult CancelForm()
        {
            ViewBag.Message = "Cancel button clicked successfully!";
            return View("WithFormActionAndFormMethodHTML5Attributes");
        }
        #endregion

        #region With jQuery Or Javascript Code
        public IActionResult WithJQueryOrJavascriptCode()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveFormJQueryCode()
        {
            ViewBag.Message = "Save button clicked successfully!";
            return View("WithJQueryOrJavascriptCode");
        }

        [HttpPost]
        public ActionResult CancelFormJQueryCode()
        {
            ViewBag.Message = "Cancel button clicked successfully!";
            return View("WithJQueryOrJavascriptCode");
        }
        #endregion
    }
}
