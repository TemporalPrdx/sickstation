using Content.Shared.Interaction.Events;
using Robust.Shared.Audio;
using Robust.Shared.Player;

namespace Content.Server.Sound
{
    public class PlaySoundOnUseSystem : EntitySystem
    {
        public override void Initialize()
        {
            base.Initialize();

            SubscribeLocalEvent<PlaySoundOnUseComponent, UseInHandEvent>(OnUseInHand);
        }

        [Obsolete]
        private void OnUseInHand(EntityUid uid, PlaySoundOnUseComponent component, UseInHandEvent args)
        {
            SoundSystem.Play(component.Sound, Filter.Pvs(uid), uid);
        }
    }
}
