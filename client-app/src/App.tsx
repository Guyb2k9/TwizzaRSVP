import "./App.css";

import { Button, Header, List, ListItem } from "semantic-ui-react";
import React, { useEffect, useState } from "react";

import axios from "axios";

function App() {
  const [events, setEvents] = useState([]);

  useEffect(() => {
    axios.get("http://localhost:5000/api/events").then((response) => {
      setEvents(response.data);
    });
  }, []);

  return (
    <div>
      <Header as="h2" icon="users" content="Twizza Events" />
      <List>
        {events.map((event: any) => (
          <List.Item key={event.id}>{event.title}</List.Item>
        ))}
      </List>
    </div>
  );
}

export default App;
