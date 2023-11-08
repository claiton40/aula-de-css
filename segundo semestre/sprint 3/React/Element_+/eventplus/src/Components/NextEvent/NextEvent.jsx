import React from 'react';
import './NextEvent.css';

const NextEvent = ( {title, description, eventDate}) => {
    return (
        <article className='event-card'>
            <h2 className='event-card__title'>
                {title}
            </h2>
            
            
            <p className='event-card__description'>
                {description}
            </p>
            <p className='event-card__description'>
                {eventDate}
            </p>
        </article>
    );
};

export default NextEvent;