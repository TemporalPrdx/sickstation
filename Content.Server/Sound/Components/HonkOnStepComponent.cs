namespace Content.Server.Sound
{
    [RegisterComponent]
    public class HonkOnStepComponent : Component
    {
        [DataField("sound")]
        public string Sound = string.Empty;
    }
}
