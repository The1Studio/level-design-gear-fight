using System;
using System.Collections.Generic;
using UnityEngine;

namespace GearGame.Utility
{
	public static class MiscUtility
	{
		public enum RoundingType
		{
			Floor = 0,
			Ceiling = 1,
			Round = 2
		}

		public static void Shuffle<T>(this IList<T> list, System.Random rng = null)
		{
		}

		public static bool IsInRange(this int i, int a, int b)
		{
			return false;
		}

		public static bool IsInRangeOf<T>(this int i, T[] array)
		{
			return false;
		}

		public static int ComputeNearestStringLevenshteinDistance(string s, string t)
		{
			return 0;
		}

		public static double EvaluateFormula(this string formula, int x)
		{
			return 0.0;
		}

		public static T GetRandom<T>(this List<T> list, System.Random random)
		{
			return default(T);
		}

		public static T[] GetWeightedProportion<T>(Tuple<float, T>[] randomObjects, int number, bool shuffleResult, System.Random rng = null)
		{
			return null;
		}

		public static Tuple<float, T> GetWeightedRandomResult<T>(Tuple<float, T>[] randomObjects, System.Random rng = null)
		{
			return null;
		}

		public static bool IsPointerOverUIObject()
		{
			return false;
		}

		public static string ConvertTimeToTimer(this float value)
		{
			return null;
		}

		public static int GetRandomValueBetween(this Vector2Int range, int seed)
		{
			return 0;
		}

		public static Vector2 AsVector2(this Vector3 vector)
		{
			return default(Vector2);
		}

		public static double GetRandomValueBetween(this Vector2 range, int seed)
		{
			return 0.0;
		}

		public static void CopyToClipboard(this string str)
		{
		}

		public static double Lerp(this double from, double to, double lerp01)
		{
			return 0.0;
		}

		public static int RoundToNearest(this int value, int nearest, RoundingType type)
		{
			return 0;
		}

		public static int RoundToNearest(this float value, int nearest, RoundingType type)
		{
			return 0;
		}

		public static float RoundToNearestFloat(this float value, float nearest, RoundingType type)
		{
			return 0f;
		}

		public static double RoundToNearest(this double value, int nearest, RoundingType type)
		{
			return 0.0;
		}

		public static void CenterAndScaleToFit(this Transform transformToAdjust, Transform newParentTransform, float widthTarget, float heightTarget, bool includeDisabled)
		{
		}
	}
}
