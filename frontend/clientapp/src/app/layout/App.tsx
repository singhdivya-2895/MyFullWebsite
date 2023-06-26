import React, { useEffect, useState } from 'react';
import { Container, } from 'semantic-ui-react';
import { Activity } from './models/Activity';
import { NavBar } from './NavBar';
import { ActivityDashboard } from '../../features/activity/dashboard/ActivityDashboard';
import { v4 as uuid } from 'uuid';
import agent from '../api/agent';

function App() {
  const [activities, setActivities] = useState<Activity[]>([]);
  const [selectedActivity, setSelectedActivity] = useState<Activity | undefined>(undefined);
  const [editMode, setEditMode] = useState(false);

  useEffect(() => {
    const fetchData = async () => {
      try {
        let response = await agent.Activities.fetchlist();
        response.forEach(activity => {
          activity.date = activity.date.split('T')[0];
          //E.g.: "2023-04-07T06:16:23.6882405"  0: 2023-04-07, 1: 06:16:23.6882405
        });
        setActivities(response);
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
  function handleFormOpen(id?: string) {
    id ? handleSelectActivity(id) : cancelSelectActivty()
    setEditMode(true);
  }
  function handleFormClose() {
    setEditMode(false);
  }
  function handleCreateOrEditActivity(activity: Activity) {
    if (activity.id) {
      setActivities([...activities.filter(x => x.id !== activity.id), activity]);
    }
    else {
      activity.id = uuid();
      setActivities([...activities, { ...activity }]);
    }
    setSelectedActivity(activity);
  }
  function handleDeleteActivity(id: string) {
    setActivities([...activities.filter(x => x.id !== id)])
  }

  return (
    <>
      <NavBar openForm={handleFormOpen} />
      <Container style={{ marginTop: '7em' }}>
        <ActivityDashboard activities={activities}
          selectedActivity={selectedActivity}
          selectActivity={handleSelectActivity}
          cancelSelectActivity={cancelSelectActivty}
          editMode={editMode}
          openForm={handleFormOpen}
          closeForm={handleFormClose}
          createOrEdit={handleCreateOrEditActivity}
          deleteActivity={handleDeleteActivity}
        />
      </Container>
    </>
  );
}

export default App;


