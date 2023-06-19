import { Button, Container, Menu } from "semantic-ui-react";


 export function NavBar(){
    return (
        <Menu inverted fixed="top">
        <Container>
         <Menu.Item header>
            < img src ="./assets/logo.png "  alt="logo" style={{marginRight:'10px'}}/>
            Reactivities
         </Menu.Item>
         <Menu.Item name="Activities"/>
         <Menu.Item>
            <Button positive content="content activity" />
         </Menu.Item>
        </Container>
        </Menu>
    )
 }

