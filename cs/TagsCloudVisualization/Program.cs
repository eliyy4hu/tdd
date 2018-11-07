﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using NUnit.Framework;
using FluentAssertions;

namespace TagsCloudVisualization
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class CircularCloudLayouter
    {
        private Point center;
        private IEnumerator<Point> spiralEnumerator;
        public List<Rectangle> addedRectangles = new List<Rectangle>();

        public CircularCloudLayouter(Point center)
        {
            var x = center.X;
            var y = center.Y;
            if (x < 0 || y < 0)
                throw new ArgumentException();
            this.center = center;
        }


        public Rectangle PutNextRectangle(Size rectangleSize)
        {
            return new Rectangle();
        }
    }

    [TestFixture]
    public class CircularCloudLayouterTests
    {
        [TestCase(-1, 1, TestName = "X less than 0")]
        [TestCase(1, -1, TestName = "Y less than 0")]
        public void ctor_ThrowsArgumentExceptionWhen(int centerX, int centerY)
        {
            Action act = () => new CircularCloudLayouter(new Point(centerX, centerY));
            act.Should().Throw<ArgumentException>();
        }
    }
}