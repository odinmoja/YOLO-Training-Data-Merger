using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace DataMerger
{
    public partial class FrmMerger : Form
    {
        public FrmMerger()
        {
            InitializeComponent();
        }

        private void FrmMerger_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to data merger");
        }

        public static List<string> GetRandomFilenames(string folderPath, int numFiles)
        {

            if (!Directory.Exists(folderPath))
            {
                throw new DirectoryNotFoundException($"Folder not found: {folderPath}");

            }
                

            if (numFiles <= 0)
            {
                return new List<string>();
            }
                

            // Get all files in the folder (filenames only, not full paths)
            var allFiles = Directory.GetFiles(folderPath)
                                    .Select(Path.GetFileName)
                                    .ToList();

            if (allFiles.Count == 0)
                return new List<string>();

            // Clamp requested number to available files
            numFiles = Math.Min(numFiles, allFiles.Count);

            var selectedFiles = new HashSet<string>();

            while (selectedFiles.Count < numFiles)
            {
                int index = Random.Shared.Next(allFiles.Count);
                selectedFiles.Add(allFiles[index]); // HashSet prevents duplicates
            }

            return selectedFiles.ToList();
        }
        public static List<string> GetMatchingFiles(string folderPath, List<string> imgFiles)
        {
            if (!Directory.Exists(folderPath))
                throw new DirectoryNotFoundException($"Folder not found: {folderPath}");

            if (imgFiles == null || imgFiles.Count == 0)
                return new List<string>();

            // Build a lookup of txt files by base filename
            var txtFilesByBaseName = Directory
                .GetFiles(folderPath, "*.txt")
                .ToDictionary(
                    f => Path.GetFileNameWithoutExtension(f),
                    f => Path.GetFileName(f),
                    StringComparer.OrdinalIgnoreCase
                );

            var result = new List<string>();

            foreach (var imgFile in imgFiles)
            {
                var baseName = Path.GetFileNameWithoutExtension(imgFile);

                if (txtFilesByBaseName.TryGetValue(baseName, out var txtFile))
                {
                    result.Add(txtFile);
                }
            }

            return result;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string sourcePathA = txtSrcA.Text;
            string sourcePathB = txtSrcB.Text;
            int numFilesA = (int)numBx1.Value;
            int numFilesB = (int)numBx2.Value;
            if (!String.IsNullOrEmpty(sourcePathA) && numFilesA > 0 &&
               !String.IsNullOrEmpty(sourcePathB) && numFilesB > 0 &&
               !String.IsNullOrEmpty(lblDest.Text) && !String.IsNullOrEmpty(lblDestLabel.Text))
            {
                List<string> dataImagesA = GetRandomFilenames((sourcePathA+"\\images"), numFilesA);
                List<string> dataLabelsA = GetMatchingFiles((sourcePathA + "\\labels"), dataImagesA);
                List<string> dataImagesB = GetRandomFilenames((sourcePathB + "\\images"), numFilesB);
                List<string> dataLabelsB = GetMatchingFiles((sourcePathB + "\\labels"), dataImagesB);
                if (dataImagesA.Count != dataLabelsA.Count)
                {
                    MessageBox.Show("Source A files number does not match labels number");
                }
                else if (dataImagesB.Count != dataImagesB.Count)
                {
                    MessageBox.Show("Source B files number does not match labels number");

                }
                else
                {
                    foreach (string image in dataImagesA)
                    {
                        File.Copy(
                            Path.Combine(sourcePathA, "images", image),
                            Path.Combine(txtDestImg.Text, image),
                                                    true
                            );

                    }
                    foreach (string label in dataLabelsA)
                    {
                        File.Copy(
                           Path.Combine(sourcePathA, "labels", label),
                           Path.Combine(txtDestLabel.Text, label),
                                                   true
                           );

                    }

                    foreach (string image in dataImagesB)
                    {
                        // File.Copy((sourcePathB + "\\images\\" + image), txtDestImg.Text);

                        File.Copy(
                        Path.Combine(sourcePathB, "images", image),
                        Path.Combine(txtDestImg.Text, image),
                                                true
                        );

                    }
                    foreach (string label in dataLabelsB)
                    {
                        //  File.Copy((sourcePathB + "\\images\\" + label), txtDestLabel.Text);

                        File.Copy(
                          Path.Combine(sourcePathB, "labels", label),
                          Path.Combine(txtDestLabel.Text, label),
                                                  true
                          );


                    }

                }

            }
            else
            {
                MessageBox.Show("Please ensure all file paths are entered; numfiles > 0; " +
                    "and the detination folders are set");
            }
            /*Todo:  Probaby need to ad  some try-catch blocks and also some sort of screen to show 
             what file failed to copy if it does*/
            MessageBox.Show("Copy Complete!");
        }
    }
}
