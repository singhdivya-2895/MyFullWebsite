import React from 'react';
import { Button, Form, Segment } from 'semantic-ui-react';
import { Activity } from '../../../app/layout/models/Activity';

interface Props {
    activity: Activity | undefined;
    closeForm: () => void;
}

export const ActivityForm = ({ activity, closeForm }: Props) => {
    return (
        <Segment clearing>
            <Form>
                <Form.Input placeholder='Title' />
                <Form.TextArea placeholder='Description' />
                <Form.Input placeholder='Category' />
                <Form.Input placeholder='City' />
                <Form.Input placeholder='Date' />
                <Form.Input placeholder='Venu' />
                <Button floated='right' positive type='submit' content='Submit' />
                <Button onClick={closeForm} floated='right' button='cancel' content='Cancel' />
            </Form>
        </Segment>
    )
}
