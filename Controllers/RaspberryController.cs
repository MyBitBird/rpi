using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Gpio;
using Microsoft.AspNetCore.Mvc;
using System.IO;



namespace rpi.Controllers
{
    [Produces("application/json")]
    [Route("")]
    [ApiController]

    public class DataController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> SayHello()
        {
            return Ok("Hi from pi!!");
        }

        [HttpGet("on/{pinNumber}")]//It may should be HttpPost but Get is easier to use
        public IActionResult SetPinOn(int pinNumber)
        {

             var pin = Pi.Gpio[pinNumber];
            pin.PinMode = GpioPinDriveMode.Output;
            pin.Write(true);
            Console.WriteLine("Set pin "+pinNumber +" on");
            return Ok();

        }

        [HttpGet("off/{pinNumber}")]
        public IActionResult SetPinOff(int pinNumber)
        {

            var pin = Pi.Gpio[pinNumber];
            pin.PinMode = GpioPinDriveMode.Output;
            pin.Write(false);
            Console.WriteLine("Set pin " + pinNumber + " off");
            return Ok();

        }


        [HttpGet("status/{pinNumber}")]
        public IActionResult GetPinStatus(int pinNumber)
        {
            return Ok(Pi.Gpio[pinNumber].ReadValue());

        }

    }

}