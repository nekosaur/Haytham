using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using Emgu.CV;
namespace Haytham
{
    public class Calibration
    {
        public Boolean Calibrated;
        public enum calibration_type { calib_Polynomial, calib_Homography};
        public calibration_type CalibrationType;
        public int CalibrationTarget = 0;

        public Matrix<double> Destination = new Matrix<double>(2, 9);
        public Matrix<double> Source = new Matrix<double>(2, 9);
        public Matrix<double> PolynomialCoeffs;
        public Matrix<double> Homography = new Matrix<double>(3, 3);
      
        // for linear method
        public Matrix<double> CameraPoint = new Matrix<double>(2, 1);
        public Matrix<double> PolynomialCoeffs_2;
        public Matrix<double> Homography2 = new Matrix<double>(3, 3);

        public void Calibrate()
        {
            switch (CalibrationType)
            {
                case Calibration.calibration_type.calib_Polynomial:
                    double X;
                    double Y;
                    Matrix<double> A = new Matrix<double>(9, 6);
                    double[] row = new double[6];
                    for (int i = 0; i < 9; i++)
                    {

                        X = Source[0, i];
                        Y = Source[1, i];

                        row[0] = 1;
                        row[1] = X;
                        row[2] = Y;
                        row[3] = X * Y;
                        row[4] = X * X;
                        row[5] = Y * Y;

                        for (int r = 0; r < 6; r++)
                        {
                            A[i, r] = row[r];
                        }
                    }

                    PolynomialCoeffs = new Matrix<double>(6, 2);
                    PolynomialCoeffs = SolveLeastSquares(A, Destination.Transpose());

                    //METState.Current.CalibrationTargetSound.Play();
                    // CvInvoke.cvSolve(AMatrix.Ptr, BMatrix.Ptr, coeffs.Ptr, 1);
                    //textBox1.Text += "\r\n Sx8= " + (B[8, 0]) + "   X8= " + row[1];
                    //textBox1.Text += "\r\n" + (B[8, 0] - (coeffs[0, 0] * row[0] + coeffs[1, 0] * row[1] + coeffs[2, 0] * row[2] + coeffs[3, 0] * row[3] + coeffs[4, 0] * row[4] + coeffs[5, 0] * row[5]));
                    //textBox1.Text += "\r\n" +( CvInvoke.cvDotProduct(roww.Ptr, coeffsY.Ptr) - SMatrix[8, 1]);
                    break;

                case Calibration.calibration_type.calib_Homography:


                    //    X = PupilMatrix[i, 0];
                    //    Y = PupilMatrix[i, 1];

                    Matrix<double> src = new Matrix<double>(2, 4);
                    Matrix<double> dst = new Matrix<double>(2, 4);

                    for (int i = 0; i < 4; i++)
                    {

                        //src[0, i] = (int)Convert.ChangeType(PupilMatrix[i, 0], typeof(int));
                        //dst[0, i] = (int)Convert.ChangeType(B[i, 0], typeof(int));
                        //src[1, i] = (int)Convert.ChangeType(PupilMatrix[i, 1], typeof(int));
                        //dst[1, i] = (int)Convert.ChangeType(B[i, 1], typeof(int));
                        src[0, i] = Source[0, i];
                        src[1, i] = Source[1, i];
                        dst[0, i] = Destination[0, i];
                        dst[1, i] = Destination[1, i];

                    }

                    IntPtr n = new IntPtr();
                    CvInvoke.cvFindHomography(src.Ptr, dst.Ptr, Homography.Ptr, Emgu.CV.CvEnum.HOMOGRAPHY_METHOD.DEFAULT,0,n);
                   // METState.Current.CalibrationTargetSound.Play();
                    break;
            }


            Calibrated = true;
        }
        public void Calibrate2()
        {

            switch ( CalibrationType)
            {
                case Calibration.calibration_type.calib_Polynomial:
                    double X;
                    double Y;
                     Matrix<double> A = new Matrix<double>(9, 6);
                    double[] row = new double[6];
                    for (int i = 0; i < 9; i++)
                    {

                        X = Lineared(Source[0, i] - CameraPoint[0, 0]);
                        Y = Lineared(Source[1, i] - CameraPoint[1, 0]);

                        row[0] = 1;
                        row[1] = X;
                        row[2] = Y;
                        row[3] = X * Y;
                        row[4] = X * X;
                        row[5] = Y * Y;

                        for (int r = 0; r < 6; r++)
                        {
                            A[i, r] = row[r];
                        }
                    }

                    PolynomialCoeffs_2 = new Matrix<double>(6, 2);
                    PolynomialCoeffs_2 = SolveLeastSquares(A, Destination.Transpose());

                    //METState.Current.CalibrationTargetSound.Play();
                    // CvInvoke.cvSolve(AMatrix.Ptr, BMatrix.Ptr, coeffs.Ptr, 1);
                    //textBox1.Text += "\r\n Sx8= " + (B[8, 0]) + "   X8= " + row[1];
                    //textBox1.Text += "\r\n" + (B[8, 0] - (coeffs[0, 0] * row[0] + coeffs[1, 0] * row[1] + coeffs[2, 0] * row[2] + coeffs[3, 0] * row[3] + coeffs[4, 0] * row[4] + coeffs[5, 0] * row[5]));
                    //textBox1.Text += "\r\n" +( CvInvoke.cvDotProduct(roww.Ptr, coeffsY.Ptr) - SMatrix[8, 1]);
                    break;

                case Calibration.calibration_type.calib_Homography:


                    //    X = PupilMatrix[i, 0];
                    //    Y = PupilMatrix[i, 1];

                    Matrix<double> src = new Matrix<double>(2, 4);
                    Matrix<double> dst = new Matrix<double>(2, 4);

                    for (int i = 0; i < 4; i++)
                    {

                        //src[0, i] = (int)Convert.ChangeType(PupilMatrix[i, 0], typeof(int));
                        //dst[0, i] = (int)Convert.ChangeType(B[i, 0], typeof(int));
                        //src[1, i] = (int)Convert.ChangeType(PupilMatrix[i, 1], typeof(int));
                        //dst[1, i] = (int)Convert.ChangeType(B[i, 1], typeof(int));
                        src[0, i] = Lineared(Source[0, i] - CameraPoint[0, 0]);
                        src[1, i] = Lineared(Source[1, i] - CameraPoint[1, 0]);
                        dst[0, i] = Destination[0, i];
                        dst[1, i] = Destination[1, i];

                    }

                    IntPtr n = new IntPtr();
                    CvInvoke.cvFindHomography(src.Ptr, dst.Ptr, Homography2.Ptr, Emgu.CV.CvEnum.HOMOGRAPHY_METHOD.DEFAULT, 0, n);
                    //METState.Current.CalibrationTargetSound.Play();
                    break;
            }


            Calibrated = true;
        }
        static public Matrix<double> SolveLeastSquares(Matrix<double> A, Matrix<double> B)
        {
            int M = A.Rows;
            int N = A.Cols;

            Matrix<double> cof = new Matrix<double>(N, 2);

            Matrix<double> U = new Matrix<double>(M, M);
            Matrix<double> W = new Matrix<double>(M, N);
            Matrix<double> V = new Matrix<double>(N, N);

            Matrix<double> c = new Matrix<double>(M, 2);
            Matrix<double> y = new Matrix<double>(N, 2);

            CvInvoke.cvSVD(A.Ptr, W.Ptr, U.Ptr, V.Ptr, Emgu.CV.CvEnum.SVD_TYPE.CV_SVD_DEFAULT);


            c = U.Transpose().Mul(B);
            for (int i = 0; i < N; i++)
            {
                y[i, 0] = c[i, 0] / W[i, i];
                y[i, 1] = c[i, 1] / W[i, i];

            }

            cof = V.Mul(y);


            return cof;

        }
        public Point Map(double inputX,double inputY, int errorX, int errorY)
        {
                    Point output = new Point();
            switch (CalibrationType)
            {
                case Calibration.calibration_type.calib_Polynomial:

                    Matrix<double> A = new Matrix<double>(1, 6);


                    double X = inputX;
                    double Y = inputY;

                    A[0, 0] = 1;
                    A[0, 1] = X;
                    A[0, 2] = Y;
                    A[0, 3] = X * Y;
                    A[0, 4] = X * X;
                    A[0, 5] = Y * Y;


                    output.X = (int)Convert.ChangeType(CvInvoke.cvDotProduct(A.Ptr, METState.Current.EyeToScene_Mapping.PolynomialCoeffs.GetCol(0).Transpose().Ptr), typeof(int));
                    output.Y = (int)Convert.ChangeType(CvInvoke.cvDotProduct(A.Ptr, METState.Current.EyeToScene_Mapping.PolynomialCoeffs.GetCol(1).Transpose().Ptr), typeof(int));
                    break;
                case Calibration.calibration_type.calib_Homography:


                    Matrix<double> src = new Matrix<double>(3, 1);
                    Matrix<double> dst = new Matrix<double>(3, 1);
                      

                        src[0, 0] = inputX;
                        src[1, 0] = inputY;
                        src[2, 0] = 1;
                        dst = Homography * src;
                        output.X = (int)Convert.ChangeType(dst[0, 0] / dst[2, 0], typeof(int));
                        output.Y = (int)Convert.ChangeType(dst[1, 0] / dst[2, 0], typeof(int));
                       // System.Diagnostics.Debug.WriteLine(gaze.X + "," + gaze.Y );

                    break;

            }

            output.X -= errorX;
            output.Y -= errorY;

                     return output;
       }
        /// <summary>
        /// Linear idea cos...
        /// </summary>
        /// <param name="inputX"></param>
        /// <param name="inputY"></param>
        /// <param name="errorX"></param>
        /// <param name="errorY"></param>
        /// <returns></returns>
        public Point Map2(double inputX, double inputY, int errorX, int errorY)
        {

        //private void btnCameraPoint_Click(object sender, EventArgs e)
        //{
        //    METState.Current.EyeToScene_Mapping.CameraPoint[0, 0] = METState.Current.pupil.Center.X;
        //    METState.Current.EyeToScene_Mapping.CameraPoint[1, 0] = METState.Current.pupil.Center.Y;
        //    btnCalibration_Homography.Enabled = true;
        //    CB_MakeLinear.Enabled = true;
        //}
            Point output = new Point();
            switch ( CalibrationType)
            {
                case Calibration.calibration_type.calib_Polynomial:
                                                                            
                    Matrix<double> A = new Matrix<double>(1, 6);


                    double X = Lineared(inputX - CameraPoint[0, 0]);
                    double Y = Lineared(inputY - CameraPoint[1, 0]);

                    A[0, 0] = 1;
                    A[0, 1] = X;
                    A[0, 2] = Y;
                    A[0, 3] = X * Y;
                    A[0, 4] = X * X;
                    A[0, 5] = Y * Y;


                    output.X = (int)Convert.ChangeType(CvInvoke.cvDotProduct(A.Ptr, METState.Current.EyeToScene_Mapping.PolynomialCoeffs_2.GetCol(0).Transpose().Ptr), typeof(int));
                    output.Y = (int)Convert.ChangeType(CvInvoke.cvDotProduct(A.Ptr, METState.Current.EyeToScene_Mapping.PolynomialCoeffs_2.GetCol(1).Transpose().Ptr), typeof(int));
                    break;
                case Calibration.calibration_type.calib_Homography:


                    Matrix<double> src = new Matrix<double>(3, 1);
                    Matrix<double> dst = new Matrix<double>(3, 1);


                    src[0, 0] = Lineared(inputX - CameraPoint[0, 0]);
                    src[1, 0] = Lineared(inputY - CameraPoint[1, 0]);
                    src[2, 0] = 1;
                    dst = Homography2 * src;

                    output.X = (int)Convert.ChangeType(dst[0, 0]/dst[2, 0], typeof(int));
                    output.Y = (int)Convert.ChangeType(dst[1, 0]/dst[2, 0], typeof(int));
                    //System.Diagnostics.Debug.WriteLine(gaze.X + "," + gaze.Y);

                    break;

            }
            output.X -= errorX;
            output.Y -= errorY;
            return output;


        }
        public double Lineared(double input)
        {// yejoor meghdar bede ke integer mishe sefr nashe

            double R_Cornea = (300 / 2) ;//???
            double H = 10;//???
            return (H / R_Cornea) * (input / Math.Sqrt(1 - (input / R_Cornea)*(input / R_Cornea)));
        }
    }
}
