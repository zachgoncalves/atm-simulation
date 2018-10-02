/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 2: ATM
 * Written by: Zachary Goncalves with code provided by Professor Frank Friedman
 */
using System;
using System.IO;
using System.Windows.Forms;

namespace ATM.Classes
{
    public class updatedFile
    {
        // updatedFile class that handles writes data from currentFile and update data from customer to a new file.
        // Author: Professor Frank Friedman, with modifications by Zachary Goncalves
        private string updatedFilePath;
        private StreamReader currentFileSR;   // Reference variable of type SR
        private int recordsWrittenCount;


        /* TO DO:
         * Write Info from customer class to updatedFile 
         * Write remaining currentFile contents to updatedFile
         */


        // Constructor with file path input
        // Create instance of StreamReader class (type) and store reference
        public updatedFile(string filePath)
        {
            recordsWrittenCount = 0;
            updatedFilePath = filePath;
            try
            {
                currentFileSR = new System.IO.StreamReader(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + updatedFilePath + "Terminate Program.","Output File Connection Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end Try
        } // end currentFileClass 

        public void putNextRecord(string record)
        {
            try
            {
                string[] lines = { "no", "yes", "maybe"};
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(updatedFilePath, "updatedFile.txt")))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
            }
            catch
            {

            }
        }

        // Read a record from the current file
        public string getNextRecord(ref Boolean endOfFileFlag)
        {
            string nextRecord;

            endOfFileFlag = false;
            nextRecord = currentFileSR.ReadLine();

            if (nextRecord == null)
            {
                endOfFileFlag = true;
            }
            else
            {
                recordsWrittenCount += 1;
            } // end if

            return (nextRecord);
        } // end getNextRecord


        // Get value of number of records read
        public int getRecordsWrittenCount()
        {
            return recordsWrittenCount;
        } // end getecordsReadCount


        // Close the input file
        public void closeFile()
        {
            currentFileSR.Close();
        } // end Sub


        // Rewind the input file
        public void rewindFile()
        {
            recordsWrittenCount = 0;
            currentFileSR.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        } // end rewindFile
    } // end currentFileClass
}