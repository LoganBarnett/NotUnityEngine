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
	[System.Serializable]
	public struct Vector2 {
		public float x;
		public float y;

		public static implicit operator UnityEngine.Vector2(Vector2 vector) {
			return new UnityEngine.Vector2(vector.x, vector.y);
		}

		public static implicit operator UnityEngine.Vector3(Vector2 vector) {
			return new Vector3(vector.x, vector.y, 0f);
		}

		public static Vector2 operator *(Vector2 vector, float multiplier) {
			return new Vector2(vector.x * multiplier, vector.y * multiplier);
		}

		public Vector2(float x, float y) {
			this.x = x;
			this.y = y;
		}
	}
}