/*
 * The MIT License (MIT)
 * 
 * Copyright (c) 2014 Logan Barnett
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
namespace NotUnityEngine {
	public static class Mathf {
		public static float Cos(float angle) {
			return (float)System.Math.Cos(angle);
		}

		public static float Sin(float angle) {
			return (float)System.Math.Sin(angle);
		}

		public static float Tan(float angle) {
			return (float)System.Math.Tan(angle);
		}

		public static float PI {
			get {
				return (float)System.Math.PI;
			}
		}

		public static float Abs(float f) {
			return System.Math.Abs(f);
		}

		public static int FloorToInt(float f) {
			return (int)f;
		}


	}
}