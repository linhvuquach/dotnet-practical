import React, { useEffect, useState } from "react";
import * as signalR from "@microsoft/signalr";

function App() {
  const [messages, setMessages] = useState([]);
  const [newMessage, setNewMessage] = useState("");

  const Host = "http://localhost:5019";
  const MyHubConn = "/mychathub";
  const ReceiveMethod = "ReceiveMessage";

  useEffect(() => {
    const connection = new signalR.HubConnectionBuilder()
      .withUrl(`${Host}${MyHubConn}`)
      .build();

    connection.on(ReceiveMethod, (message) => {
      setMessages((prevMessages) => [...prevMessages, message]);
    });

    connection
      .start()
      .then(() => {
        console.log("Connection started!");
      })
      .catch((error) => {
        console.error("Error starting connection:", error);
      });

    return () => {
      connection.stop().then(() => {
        console.log("Connection stopped!");
      });
    };
  }, []);

  const handleSendNotification = async () => {
    try {
      const response = await fetch(`${Host}/send-notification`, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(newMessage),
      });

      if (response.ok) {
        setNewMessage("");
      }
    } catch (error) {
      console.error("Error sending notification:", error);
    }
  };

  return (
    <div>
      <input
        type="text"
        value={newMessage}
        onChange={(e) => setNewMessage(e.target.value)}
        placeholder="Enter message"
      />
      <button onClick={handleSendNotification}>Send</button>

      <div>
        <h2>Received Messages:</h2>
        {messages.map((msg, index) => (
          <div key={index}>{msg}</div>
        ))}
      </div>
    </div>
  );
}

export default App;
