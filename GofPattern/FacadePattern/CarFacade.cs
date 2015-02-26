using System;

namespace FacadePattern
{
    public class CarFacade : ICar
    {
        private readonly Body _body;
        private readonly Engine _engine;
        private readonly Seats _seats;
        private readonly Wheels _wheels;
        public CarFacade()
        {
            _body = new Body();
            _engine = new Engine();
            _seats = new Seats();
            _wheels = new Wheels();
        }
        public void BuildCar()
        {
            Console.WriteLine("Started Making Car..............");
            _body.AddBody(BodyType.Sedan);
            _engine.AddEngine(6);
            _seats.AddSeats(4);
            _wheels.AddWheels(4);
            Console.WriteLine("Ended Making Car................");
        }
    }
}