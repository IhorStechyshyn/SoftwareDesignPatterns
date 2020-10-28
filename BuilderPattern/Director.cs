namespace SoftwareDesignPatterns
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildBaseVersion()
        {
            _builder.BuildAirCondition();
        }

        public void BuildLifeVersion()
        {
            _builder.BuildAirCondition();
            _builder.BuildAutomaticTransmission();
        }

        public void BuildZenVersion()
        {
            _builder.BuildAirCondition();
            _builder.BuildAutomaticTransmission();
            _builder.BuildAllWheelDrive();
        }
    }
}
