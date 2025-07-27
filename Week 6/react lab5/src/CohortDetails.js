// src/CohortDetails.js
import React from 'react';
import styles from './CohortDetails.module.css';

const CohortDetails = ({ title, status }) => {
  const headingStyle = {
    color: status === 'ongoing' ? 'green' : 'blue'
  };

  return (
    <div className={styles.box}>
      <h3 style={headingStyle}>{title}</h3>
      <dl>
        <dt>Status:</dt>
        <dd>{status}</dd>
      </dl>
    </div>
  );
};

export default CohortDetails;

