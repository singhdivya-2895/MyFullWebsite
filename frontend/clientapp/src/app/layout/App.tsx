import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Container, } from 'semantic-ui-react';
import { Activity } from './models/Activity';
import { NavBar } from './NavBar';
import { ActivityDashboard } from '../../features/activity/dashboard/ActivityDashboard';

function App() {
  const [activities, setActivities] = useState<Activity[]>([]);
  const [selectedActivity, setSelectedActivity] = useState<Activity | undefined>(undefined);

  useEffect(() => {
    const fetchData = async () => {
      try {
        let response = await axios.get('http://localhost:5261/api/activities');
        setActivities(response.data);
      }
      catch (error) {
        console.error(`Error:${error}`)
      }
    };
    fetchData();
  }, [])

  function handleSelectActivity(id: string) {
    setSelectedActivity(activities.find(x => x.id === id))
  }

  function cancelSelectActivty() {
    setSelectedActivity(undefined);
  }

  return (
    <>
      <NavBar />
      <Container style={{ marginTop: '7em' }}>
        <ActivityDashboard activities={activities}
          selectedActivity={selectedActivity}
          selectActivity={handleSelectActivity}
          cancelSelectActivity={cancelSelectActivty}
        />
      </Container>
    </>
  );
}

export default App;
