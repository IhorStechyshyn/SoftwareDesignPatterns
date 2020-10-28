namespace SoftwareDesignPatterns
{
    public class ConcreteBuilder : IBuilder
    {
        private Car _car = new Car();

        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _car = new Car();
        }

        public void BuildAirCondition()
        {
            _car.Add("Air Condition");
        }

        public void BuildAutomaticTransmission()
        {
            _car.Add("Automatic Transmission");
        }

        public void BuildAllWheelDrive()
        {
            _car.Add("4x4 drive");
        }

        public Car GetCar()
        {
            Car result = _car;

            Reset();

            return result;
        }
    }
}
