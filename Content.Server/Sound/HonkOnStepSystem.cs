using Content.Shared.StepTrigger.Systems;
using Robust.Shared.Audio;
using Robust.Shared.Player;

namespace Content.Server.Sound
{
    public class HonkOnStepSystem : EntitySystem
    {
        public override void Initialize()
        {
            base.Initialize();

            SubscribeLocalEvent<HonkOnStepComponent, StepTriggeredEvent>(OnStepTrigger);
        }

        [Obsolete]
        private void OnStepTrigger(EntityUid uid, HonkOnStepComponent component, ref StepTriggeredEvent args)
        {
            SoundSystem.Play(component.Sound, Filter.Pvs(args.Tripper), uid);
        }
    }
}
