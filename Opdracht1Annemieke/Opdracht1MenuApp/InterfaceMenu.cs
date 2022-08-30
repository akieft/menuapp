namespace Opdracht1MenuApp
{
    /// <summary>
    ///     The interface for a menu item.
    /// </summary>
    internal interface InterfaceMenu
    {
        /// <summary>
        ///     The title of the menu item in the menu
        /// </summary>
        string Title { get; }

        /// <summary>
        ///     Execute the task of the menu item.
        /// </summary>
        void Execute();
    }
}