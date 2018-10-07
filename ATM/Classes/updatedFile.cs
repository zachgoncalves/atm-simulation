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
        private StreamWriter outputFile;   // Reference variable of type SW
        private int recordsWrittenCount;

        // Constructor with file path input
        // Create instance of StreamReader class (type) and store reference
        public updatedFile(string filePath)
        {
            recordsWrittenCount = 0;
            updatedFilePath = filePath;
        } // end currentFileClass 

        public void putNextRecord(string record)
        {
            try
            {
                using (outputFile = new StreamWriter(updatedFilePath))
                {
                    outputFile.WriteLine(record);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot write file" + updatedFilePath + "Terminate Program." + ex, "Output File Connection Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Get value of number of records read
        public int getRecordsWrittenCount()
        {
            return recordsWrittenCount;
        } // end getecordsReadCount


        // Close the input file
        public void closeFile()
        {
            outputFile.Close();
        } // end Sub


        // Rewind the input file
        public void rewindFile()
        {
            recordsWrittenCount = 0;
            outputFile.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        } // end rewindFile
    } // end currentFileClass
}