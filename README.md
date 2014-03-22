NotUnityEngine
==============

A full replacement of Unity's API for the purposes of thread use and extracting general purpose code from a Unity codebase without pain. 

Usage
=====

Simply copy this code into Assets/Plugins/NotUnityPlugin. Change "using UnityEngine;" to "using NotUnityEngine;" in the files that you wish to not be so tightly bound to Unity.

Why?
====
In the course of introducing threading to my game, I found a lot of frustration in finding out exactly where I had violated Unity's threadsafety protections. Unity would show an error in the log with no stack, and my thread would die with no ability to handle any kind of error. In a non-trivial codebase, this can be a nightmare to debug. I also found that there are many parts of the Unity API that have threading protection where you wouldn't expect it (such as the [Random](http://docs.unity3d.com/Documentation/ScriptReference/Random.html "Random") class). Fortunately, C# has the implicit cast operator, which allows you to implicitly coerce from one type to another. In this way we can provide an API that looks exactly like Unity's, and can be used interchangibly with Unity's.

There's also some handy things in the Unity API that may be undesirable to rewrite yourself (like [Random.insideUnitCircle](http://docs.unity3d.com/Documentation/ScriptReference/Random-insideUnitCircle.html "Random.insideUnitCircle"). Someone will have to duplicate the functionality once, but once that is done, it should be publicly accessible here.

A final motivation is that decoupling your game's logic from Unity can save you a lot of heartache in the long run. This library can assist with that, so you can use things such as Vector3 in an external library without needing to include the UnityEngine.dll.

Did you duplicate the entire Unity API?
=======================================
At time of writing, no. This is not quite the goal of this library anyways. Duplicating functionality such as MonoBehaviour doesn't make much sense (currently), but duplicating the utility and signature of Mesh would be very useful.
