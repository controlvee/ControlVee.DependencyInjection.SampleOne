using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAPIandJquery.Controllers
{
    public class TestController : Controller
    {
        /// <summary>
        /// Why suggesting readonly?
        /// </summary>
        ITransient _theTransient;
        ISingleton _theSingleton;
        IScoped _theScoped;
        ILogger<TestController> _theLogger;

        public TestController(ITransient injectedTransientItem, ISingleton injectedSingletonItem, IScoped injectedScopedItem, ILogger<TestController> injectedLogger)
        {
            _theTransient = injectedTransientItem;
            _theSingleton = injectedSingletonItem;
            _theScoped = injectedScopedItem;
            _theLogger = injectedLogger;
            _theLogger.LogDebug($"The TestController that was created");
            _theLogger.LogDebug($"The Transient that was injected has data: {injectedTransientItem.Data}");
        }

        public IActionResult Index()
        {
            ViewBag.Single = _theSingleton.Data;
            ViewBag.Transient = _theTransient.Data;
            ViewBag.Scoped = _theScoped.Data;
            ViewBag.XXX = 23;
            ViewBag.YYY = "Hello";


            return View();
        }
    }
}
