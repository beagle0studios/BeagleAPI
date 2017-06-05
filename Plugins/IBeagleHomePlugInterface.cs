using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Window.StdW;
using BeagleAPI.Controls;
using System.Drawing;

namespace BeagleAPI.Plugins
{
    public interface IBeagleHomePlugInterface
    {
        /// <summary>
        /// Gibt den Namen des Plugins zurück. Namenskonventionen siehe Dokumentation.
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// Enthält die ID des Plugins.
        /// </summary>
        string GetID
        {
            get;
            set;
        }

        /// <summary>
        /// Gibt den Typ des Plugins an.
        /// </summary>
        string AppType
        {
            get;
        }

        /// <summary>
        /// Gibt das Icon des Plugins an. In der Regel ist das das Icon es Fensters.
        /// </summary>
        Icon AppIcon
        {
            get;
        }

        string GenerateID();
        void InstallBeagleHome();
        //BeagleOS
        /// <summary>
        /// Diese Mehode wird aufgerufen, wenn das Plugin geladen und geöffnet wird.
        /// </summary>
        /// <returns>Gibt das Fenster wieder, das eventuell vorhanden ist, andernfalls null.</returns>
        StdWin Initialize();
        /// <summary>
        /// Initialize your new App. For example, set app settings.
        /// </summary>
        /// <param name="window">The window to initialize.</param>
        /// <param name="param_info">optional: additional information about window</param>
        void SetAppParameters(StdWin window, params string[] args);

        /// <summary>
        /// Create new window. Call StdWin.Initialize()!
        /// </summary>
        /// <returns>Return your created window</returns>
        StdWin CreateWindow();
        
    }
}
