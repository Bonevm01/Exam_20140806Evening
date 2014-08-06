namespace Computers
{
    public interface IMotherboard
    {
        /// <summary>
        /// Load the value stored in the ram memory attached to this motherboard
        /// </summary>
        /// <returns>returns integer value of value stored in the available ram memory</returns>
        int LoadRamValue();

        /// <summary>
        /// Save in the ram memory an integer value
        /// </summary>
        /// <param name="value">integer value</param>
        void SaveRamValue(int value);

        /// <summary>
        /// Manage video card and send a comand to prind a string
        /// </summary>
        /// <param name="data">Message to be printed by VideoCard</param>
        void DrawOnVideoCard(string data);
    }
}
