using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using Verse.AI;

namespace FF_Drugs
{
	public class Freefolk_WanderSad : MentalState
	{
		public override RandomSocialMode SocialModeMax()
		{
			return RandomSocialMode.Off;
		}
		public override void MentalStateTick()
		{
		}
		public override void PreStart()
		{
			base.PreStart();
			causedByMood = true;
		}
	}
}
