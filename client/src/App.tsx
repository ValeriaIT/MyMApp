import { List, ListItem, ListItemText, Typography } from "@mui/material";
import axios from "axios";
import { useEffect, useState } from "react";

function App() {
  const [topics, setTopics] = useState<Topic[]>([]);
  useEffect(() => {
    axios
      .get<Topic[]>("https://localhost:5001/api/topics")
      .then((response) => setTopics(response.data))

      .catch((error) => {
        console.error("Error fetching data:", error);
      });
    return () => {
      // Cleanup function if needed
    };
  }, []);
  return (
    <>
      <Typography variant="h3">Welcome to the Topic App</Typography>
      <Typography variant="h3">Topics:</Typography>
      <List>
        {topics.map((topic) => (
          <ListItem key={topic.id}>
            <ListItemText>
              {topic.title} - {topic.description}
            </ListItemText>
          </ListItem>
        ))}
      </List>
    </>
  );
}

export default App;
