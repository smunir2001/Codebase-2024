/*
    Sami Munir
    smunir2001@gmail.com
    Rutgers University
    November 9th, 2023
    AI Face Recognition
*/

using OpenCvSharp;
using System;
public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("AI Face Recognition");

        using (var capture = new VideoCapture(0))
        using (var window = new Window("AI Face Recognition"))
        using (var faceCascade = new CascadeClassifier("haarcascade_frontalface_default.xml"))
        {
            while (true) {
                using (var frame = new Mat()) {
                    capture.Read(frame);
                    if (frame.Empty()) {
                        break;
                    }
                    var grayFrame = new Mat();
                    Cv2.CvtColor(frame, grayFrame, ColorConversionCodes.BGR2GRAY);
                    var faces = faceCascade.DetectMultiScale(
                        grayFrame, scaleFactor: 1.1, minNeighbors: 5, flags: HaarDetectionTypes.ScaleImage, minSize: new Size(30, 30)
                    );
                    foreach (var rect in faces) {
                        Cv2.Rectangle(frame, rect, Scalar.Red, 2);
                    }
                    window.ShowImage(frame);
                }
            }
        }
    }
}