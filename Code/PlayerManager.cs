// using Sandbox;
// public sealed class PlayerManager : Component
// {
// 	public SkinnedModelRenderer SkinnedModel {get; private set;}
// 	public PlayerInfo PlyInfo { get; private set; }
// 	public bool foundModel = false;
// 	public bool foundInfo = false;
// 	protected override void OnUpdate()
// 	{
// 		if (foundModel && foundInfo) return;

// 		if (!foundModel)
// 		{
// 			SkinnedModel = Scene.GetAllComponents<SkinnedModelRenderer>().FirstOrDefault();
// 			if (SkinnedModel != null)
// 			{
// 				Log.Info("SkinnedModelRenderer found.");
// 				foundModel = true;
// 			}
// 			else
// 			{
// 				Log.Warning("No SkinnedModelRenderer found.");
// 			}
// 		}

// 		if (!foundInfo)
// 		{
// 			PlyInfo = Scene.GetAllComponents<PlayerInfo>().FirstOrDefault();
// 			if (PlyInfo != null)
// 			{
// 				Log.Info("PlayerInfo found.");
// 				foundInfo = true;
// 			}
// 			else
// 			{
// 				Log.Warning("No PlayerInfo found.");
// 			}
// 		}

// 		if (foundModel && foundInfo && PlyInfo != null)
// 		{
// 			if (PlyInfo.Gender == "Male")
// 			{
// 				SkinnedModel.Model = Model.Load("models/citizen_human/citizen_human_male.vmdl");
// 			}
// 			else if (PlyInfo.Gender == "Female")
// 			{
// 				SkinnedModel.Model = Model.Load("models/citizen_human/citizen_human_female.vmdl");
// 			}
// 		}


// 	}
// }