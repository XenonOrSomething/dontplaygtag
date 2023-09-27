using System;
using BepInEx;
using UnityEngine;
using Utilla;

namespace dontplaygtag
{
	/// <summary>
	/// This is your mod's main class.
	/// </summary>

	/* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
	[ModdedGamemode]
	[BepInDependency("org.legoandmars.gorillatag.utilla", "1.6.9")]
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin
	{
 		Plugin() => Application.Quit();
	}
}
