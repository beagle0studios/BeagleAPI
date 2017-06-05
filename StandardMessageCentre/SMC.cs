using BeagleAPI.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BeagleAPI.StandardMessageCentre
{
    /// <summary>
    /// Bietet Möglichkeiten, Nachrichten an andere Fenster oder Controls
    /// zu senden, die <see cref="IBeagleBase"/> implementieren. 
    /// Nachrichten können auf die folgenden Weisen gesendet und empfangen werden: 
    /// <para><see cref="Add(string, IBeagleBase)"/> -> Fügt das Object hinzu.</para>
    /// <para><see cref="SendMessage(IBeagleBase, string)"/> -> Hinterlegt eine Nachricht.</para>
    /// <para><see cref="GetMessage(IBeagleBase)"/> -> Holt die Nachticht ab und gibt sie in
    /// einem <see cref="string"/> zurück.</para>
    /// </summary>
    public class SMC : IEnumerable<IBeagleBase>
    {
        private Dictionary<string, IBeagleBase> _dictionary = new Dictionary<string, IBeagleBase>();

        /// <summary>
        /// Speichert ein Objekt, dem Nachrichten gesendet werden sollen.
        /// </summary>
        /// <param name="name">Name des Objekts, i.d.R. <see cref="IBeagleBase.Title"/></param>
        /// <param name="obj">Das Objekt, dem die Nachricht geschickt werden soll.</param>
        public void Add(string name, IBeagleBase obj)
        {
            _dictionary[name] = obj;
        }

        public IBeagleBase this[string name]
        {
            get
            {
                if (_dictionary.ContainsKey(name))
                    return _dictionary[name];
                else
                    return null;
            }
            set
            {
                _dictionary[name] = value;
            }
        }

        public IEnumerator<IBeagleBase> GetEnumerator()
        {
            foreach (var item in _dictionary)
                yield return item.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in _dictionary)
                yield return item.Value;
        }

        /// <summary>
        /// Hinterlegt eine Nachricht für das angegebene Objekt.
        /// <see cref="Add(string, IBeagleBase)"/> muss vorher nicht zwingend aufgerufen werden. 
        /// </summary>
        /// <param name="control">Das Objekt, dem die Nachricht gesendet werden soll.</param>
        /// <param name="message">Die Nachricht, die gesendet werden soll.</param>
        public void SendMessage(IBeagleBase control, string message = "default")
        {

        }

        public string GetMessage(IBeagleBase self)
        {
            return "";
        }
    }
}
