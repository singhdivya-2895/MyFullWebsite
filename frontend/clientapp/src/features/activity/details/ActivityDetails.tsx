import React from 'react';
import { Button, Card, Image } from 'semantic-ui-react';
import { Activity } from '../../../app/layout/models/Activity';

interface Props {
    activity: Activity;
    cancelSelectActivity: () => void;
    openForm: (id: string) => void;
}

export const ActivityDetails = ({ activity, cancelSelectActivity, openForm }: Props) => {
    return (
        <Card fluid>
            <Image src={`/assets/categoryImages/${activity.category}.jpg`} />

            <Card.Content>
                <Card.Header>{activity.title}</Card.Header>
                <Card.Meta>
                    <span>{activity.date}</span>
                </Card.Meta>
                <Card.Description>
                    {activity.description}
                </Card.Description>
            </Card.Content>
            <Card.Content extra>
                <Button.Group width='2' />
                <Button onClick={() => openForm(activity.id)} basic color='blue'
                    content='Edit' />
                <Button onClick={cancelSelectActivity}
                    basic color='grey' content='Cancel' />
            </Card.Content>

        </Card>
    )
}






