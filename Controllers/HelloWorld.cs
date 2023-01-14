using Microsoft.AspNetCore.Mvc;
namespace Hello.Luska;

[ApiController]
[Route("/")]

public class HelloWorld : ControllerBase {
  [HttpGet]
  public ActionResult Hello() {
    return Ok("Luska");
  }
}