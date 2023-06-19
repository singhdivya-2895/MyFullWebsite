import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Container, } from 'semantic-ui-react';
import { Activity } from './models/Activity';
import { NavBar } from './NavBar';
import { ActivityDashboard } from '../../features/activity/dashboard/ActivityDashboard';

  function App() {
  const [activities, setActivities] = useState<Activity[]>([]);

  useEffect(() => {
    const fetchData = async () => {
    try{
      let response =  await axios.get('http://localhost:5261/api/activities')
      console.log(`You Could ${response.data}`)
      setActivities(response.data);
    }
    catch(error){
     console.error(`Error:${error}`)
    }};
      fetchData();
  }, [])

  return (
    <>
      <NavBar/>
      <Container style = {{marginTop : '7em'}}>
       <ActivityDashboard activities={activities}/>
      </Container>
    </>
  );
}

export default App;
